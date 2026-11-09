using NUnit.Framework;
using OmiLAXR.Composers;
using OmiLAXR.TrackingBehaviours;
using OmiLAXR.xAPI.Composers;
using UnityEngine;
using xAPI.Registry;

namespace OmiLAXR.xAPI.Tests
{
    public class MockTrackingBehaviour : TrackingBehaviour
    {
        protected override void AfterFilteredObjects(Object[] objects)
        {
        }
    }

    public class TestComposer : xApiComposer<MockTrackingBehaviour>
    {
        public static readonly Author TestAuthor = new Author("Test Author", "author@omilaxr.dev");

        public override Author GetAuthor() => TestAuthor;

        protected override void Compose(MockTrackingBehaviour tb)
        {
        }

        public xApiStatement.Builder Builder => actor;
    }

    /// <summary>
    /// Provides a composer with a statement builder like a real xAPI composer has at runtime.
    /// </summary>
    public abstract class xApiTestFixture
    {
        protected static xAPI_Contexts xapi => xApiRegistry.definitions;

        protected GameObject Root;
        protected xApiRegistry Registry;
        protected TestComposer Composer;

        [SetUp]
        public void SetUpComposer()
        {
            Root = new GameObject("xAPI Data Provider");
            Registry = Root.AddComponent<xApiRegistry>();
            var composerObject = new GameObject("Composer");
            composerObject.transform.SetParent(Root.transform);
            Composer = composerObject.AddComponent<TestComposer>();
        }

        [TearDown]
        public void TearDownComposer()
        {
            Object.DestroyImmediate(Root);
        }

        protected xApiStatement CreateStatement()
            => Composer.Builder
                .Does(xapi.systemControl.verbs.started)
                .Activity(xapi.systemControl.activities.game)
                .ByActor(new xAPI_Actor("Learner", "learner@omilaxr.dev"));
    }
}
