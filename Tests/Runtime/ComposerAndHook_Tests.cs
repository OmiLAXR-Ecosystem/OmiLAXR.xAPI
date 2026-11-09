using System;
using System.Collections.Generic;
using NUnit.Framework;
using OmiLAXR.Composers;
using OmiLAXR.Context;
using OmiLAXR.TrackingBehaviours.System;
using OmiLAXR.xAPI.Composers;
using OmiLAXR.xAPI.Composers.System;
using OmiLAXR.xAPI.Hooks;
using UnityEngine;
using Object = UnityEngine.Object;

namespace OmiLAXR.xAPI.Tests
{
    public class ComposerAndHook_Tests : xApiTestFixture
    {
        private GameObject _pipelineObject;
        private SystemTrackingBehaviour _system;
        private SystemComposer _systemComposer;
        private readonly List<xApiStatement> _statements = new List<xApiStatement>();
        private readonly List<Object> _created = new List<Object>();

        [SetUp]
        public void SetUpPipeline()
        {
            _pipelineObject = new GameObject("Pipeline");
            _pipelineObject.SetActive(false);
            var pipeline = _pipelineObject.AddComponent<Pipeline>();
            var actor = _pipelineObject.AddComponent<Actor>();
            actor.actorName = "Learner";
            actor.actorEmail = "learner@omilaxr.dev";
            _system = _pipelineObject.AddComponent<SystemTrackingBehaviour>();
            pipeline.StartPipeline();

            var composerObject = new GameObject("System Composer");
            composerObject.transform.SetParent(Root.transform);
            _systemComposer = composerObject.AddComponent<SystemComposer>();
            _systemComposer.AfterComposed += (_, s) => _statements.Add((xApiStatement)s);
            _statements.Clear();
        }

        [TearDown]
        public void TearDownPipeline()
        {
            _pipelineObject.GetComponent<Pipeline>().StopPipeline();
            Object.DestroyImmediate(_pipelineObject);
            foreach (var o in _created)
                Object.DestroyImmediate(o);
            _created.Clear();
        }

        private T CreateContext<T>() where T : Component
        {
            var go = new GameObject(typeof(T).Name);
            _created.Add(go);
            return go.AddComponent<T>();
        }

        [Test]
        public void SystemComposer_Composes_Started_And_Ended_Statements()
        {
            // Arrange
            var start = new DateTime(2025, 5, 6, 7, 8, 9, DateTimeKind.Utc);

            // Act
            _system.OnStartedGame.Invoke(_system, start);
            _system.OnQuitGame.Invoke(_system, start.AddMinutes(5));

            // Assert
            Assert.AreEqual(2, _statements.Count);
            Assert.IsTrue(_statements[0].MatchKeys("started", "game"));
            Assert.AreEqual(start, _statements[0].GetTimestamp());
            Assert.AreEqual("Learner", _statements[0].GetActor().Name);
            Assert.IsTrue(_statements[0].HasExtensionKey("name"));
            Assert.AreEqual("Pipeline", _statements[0].GetSenderPipelineInfo().Name);
            Assert.IsTrue(_statements[1].MatchKeys("ended", "game"));
            Assert.AreEqual(ComposerGroup.System, _systemComposer.GetGroup());
            Assert.AreEqual("Sergej Görzen", _systemComposer.GetAuthor().Name);
            Assert.AreEqual("1.0.3", _systemComposer.GetDataStandardVersion());
        }

        [Test]
        public void SystemComposer_Composes_Pause_And_Focus_Changes()
        {
            // Act
            _system.OnPausedGame.Invoke(_system, DateTime.Now, true);
            _system.OnPausedGame.Invoke(_system, DateTime.Now, false);
            _system.OnFocusedGame.Invoke(_system, DateTime.Now, true);
            _system.OnFocusedGame.Invoke(_system, DateTime.Now, false);

            // Assert
            CollectionAssert.AreEqual(new[] { "paused", "resumed", "focused", "unfocused" },
                _statements.ConvertAll(s => s.GetVerb().Key));
        }

        [Test]
        public void SystemComposer_Disabled_Composer_Sends_Nothing()
        {
            // Act
            _systemComposer.enabled = false;
            _system.OnStartedGame.Invoke(_system, DateTime.Now);

            // Assert
            Assert.IsEmpty(_statements);
        }

        [Test]
        public void ScenarioContextHook_Adds_Game_Scene_And_Version_Context()
        {
            // Arrange
            var hook = CreateContext<ScenarioContextHook>();
            var statement = CreateStatement();

            // Act
            var result = (xApiStatement)hook.AfterCompose(statement);

            // Assert
            Assert.AreSame(statement, result);
            Assert.IsTrue(result.HasContextKey("game"));
            Assert.IsTrue(result.HasContextKey("learningScenario"));
            Assert.IsTrue(result.HasContextKey("version"));
        }

        [Test]
        public void ScenarioContextHook_Uses_Scenario_Context_Components()
        {
            // Arrange
            var hook = CreateContext<ScenarioContextHook>();
            CreateContext<ScenarioLanguage>().language = Types.Languages.de;
            CreateContext<PlatformInformation>();
            var registration = CreateContext<Registration>();
            registration.uuid = Guid.NewGuid().ToString();

            // Act
            var result = (xApiStatement)hook.AfterCompose(CreateStatement());

            // Assert
            Assert.AreEqual("de", result.GetLanguage());
            StringAssert.Contains("::OmiLAXR.xAPIv2.2.5::", result.GetPlatform());
            Assert.AreEqual(new Guid(registration.uuid), result.GetRegistration());
        }

        [Test]
        public void ScenarioContextHook_Ignores_Registration_Without_Uuid()
        {
            // Arrange
            var hook = CreateContext<ScenarioContextHook>();
            CreateContext<Registration>();

            // Act & Assert
            Assert.DoesNotThrow(() => hook.AfterCompose(CreateStatement()));
        }

        [Test]
        public void TimestampAnonymizerHook_Shifts_Timestamp_By_Offset()
        {
            // Arrange
            var hook = CreateContext<TimestampAnonymizerHook>();
            hook.hourOffset = 3;
            var timestamp = new DateTime(2025, 1, 1, 12, 0, 0, DateTimeKind.Utc);

            // Act
            var result = (xApiStatement)hook.AfterCompose(CreateStatement().WithTimestamp(timestamp));

            // Assert
            Assert.AreEqual(timestamp.AddHours(3), result.GetTimestamp());
        }

        [Test]
        public void xApiHook_Passes_Through_Foreign_Statements()
        {
            // Arrange
            var hook = CreateContext<TimestampAnonymizerHook>();
            var foreign = new ForeignStatement();

            // Act & Assert
            Assert.AreSame(foreign, hook.AfterCompose(foreign));
        }

        private sealed class FakeContext : IRegistrationProvider, ILanguageProvider, IPlatformInfoProvider, IFpsProvider
        {
            public Guid? GetRegistration() => new Guid("11111111-2222-3333-4444-555555555555");
            public string GetLanguageCode() => "fr";
            public string GetPlatformString(string module, string version, IComposer composer) => $"Fake:{module}:{version}";
            public int? GetFps() => 72;
        }

        [Test]
        public void ScenarioContextHook_Uses_Injected_Providers_Without_Scene_Objects()
        {
            // Arrange
            var hook = CreateContext<ScenarioContextHook>();
            var context = new FakeContext();
            ScenarioContext.Registration = context;
            ScenarioContext.Language = context;
            ScenarioContext.Platform = context;
            ScenarioContext.Fps = context;

            try
            {
                // Act
                var result = (xApiStatement)hook.AfterCompose(CreateStatement());

                // Assert
                Assert.AreEqual("fr", result.GetLanguage());
                Assert.AreEqual("Fake:xAPI:2.2.5", result.GetPlatform());
                Assert.AreEqual(context.GetRegistration(), result.GetRegistration());
                Assert.IsTrue(result.HasContextKey("fps"));
            }
            finally
            {
                ScenarioContext.Reset();
            }
        }

        [Test]
        public void xApiStatement_Default_Timestamp_Comes_From_Clock()
        {
            // Arrange
            var now = new DateTime(2025, 6, 7, 8, 9, 10);
            Utils.Clock.Current = new FixedClock(now);

            try
            {
                // Act
                var statement = CreateStatement();

                // Assert
                Assert.AreEqual(now, statement.GetTimestamp());
                Assert.AreEqual(now, statement.CreatedAt);
            }
            finally
            {
                Utils.Clock.Current = null;
            }
        }

        private sealed class FixedClock : Utils.IClock
        {
            public FixedClock(DateTime now) => Now = now;
            public DateTime Now { get; }
            public DateTime UtcNow => Now.ToUniversalTime();
        }

        [Test]
        public void Context_Instance_Is_Refreshed_After_Destroy()
        {
            // Arrange
            var first = CreateContext<ScenarioLanguage>();
            Assert.AreSame(first, ScenarioLanguage.Instance);

            // Act
            Object.DestroyImmediate(first.gameObject);
            var second = CreateContext<ScenarioLanguage>();

            // Assert
            Assert.AreSame(second, ScenarioLanguage.Instance);
        }

        private sealed class ForeignStatement : IStatement
        {
            public string GetOrigin() => "";
            public void SetOrigin(string origin) { }
            public Guid GetId() => Guid.Empty;
            public void SetComposer(IComposer composer) { }
            public bool IsFromComposer<T>() where T : IComposer => false;
            public IComposer GetComposer() => null;
            public void SetOwner(TrackingBehaviours.ITrackingBehaviour trackingBehaviour) { }
            public bool IsDiscarded() => false;
            public void Discard() { }
            public IStatement Clone() => this;
            public string ToDataStandardString(string version = null) => "";
            public string ToJsonString(bool pretty = false, string version = null) => "";
            public string ToShortString() => "";
            public Utils.CsvFormat ToCsvFormat(bool flatten = false, string version = null) => null;
            public string GetTimestampString() => "";
            public PipelineInfo GetSenderPipelineInfo() => default;
        }
    }
}
