using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OmiLAXR.Types;
using OmiLAXR.xAPI.Composers;
using xAPI.Registry;

namespace OmiLAXR.xAPI.Tests
{
    public class xApiStatement_Tests : xApiTestFixture
    {
        [Test]
        public void xApiStatement_Tests_Builder_Creates_Statement_From_Composer()
        {
            // Act
            var stmt = CreateStatement();

            // Assert
            Assert.AreEqual(xapi.systemControl.verbs.started, stmt.GetVerb());
            Assert.AreEqual(xapi.systemControl.activities.game, stmt.GetActivity());
            Assert.AreEqual(Registry.uri, stmt.GetUri());
            Assert.AreEqual(Registry.uri, stmt.GetOrigin());
            Assert.AreSame(Composer, stmt.GetComposer());
            Assert.IsTrue(stmt.IsFromComposer<TestComposer>());
            Assert.AreEqual(TestComposer.TestAuthor.Name, stmt.GetAuthority().Name);
            Assert.AreEqual(TestComposer.TestAuthor.Email, stmt.GetAuthority().Email);
            Assert.AreEqual("Learner", stmt.GetActor().Name);
            Assert.AreNotEqual(Guid.Empty, stmt.GetId());
            Assert.AreEqual("en", stmt.GetLanguage());
            Assert.IsFalse(stmt.IsDiscarded());
        }

        [Test]
        public void xApiStatement_Tests_Matches_Verb_And_Activity()
        {
            // Arrange
            var stmt = CreateStatement();

            // Assert
            Assert.IsTrue(stmt.HasVerbKey("started"));
            Assert.IsTrue(stmt.HasVerb("systemControl.verbs.started"));
            Assert.IsTrue(stmt.HasActivityKey("game"));
            Assert.IsTrue(stmt.HasActivity("systemControl.activities.game"));
            Assert.IsTrue(stmt.MatchKeys("started", "game"));
            Assert.IsTrue(stmt.MatchPaths("systemControl/verbs/started", "systemControl/activities/game", '/'));
            Assert.IsFalse(stmt.MatchKeys("ended", "game"));
        }

        [Test]
        public void xApiStatement_Tests_Change_Methods_Replace_Values()
        {
            // Arrange
            var stmt = CreateStatement();
            var registration = Guid.NewGuid();

            // Act
            stmt.ChangeVerb(xapi.systemControl.verbs.ended)
                .ChangeActivity(xapi.systemControl.activities.level, xapi.systemControl.extensions.activity.name("lvl"))
                .WithUri("https://example.org/xapi")
                .WithLanguage("de")
                .WithPlatform("TestPlatform")
                .WithRegistration(registration)
                .WithInstructor(new xAPI_Actor("Teacher", "teacher@omilaxr.dev"))
                .ChangedBy("Other Author", "other@omilaxr.dev");

            // Assert
            Assert.IsTrue(stmt.MatchKeys("ended", "level"));
            Assert.IsTrue(stmt.HasExtensionKey("name"));
            Assert.AreEqual("https://example.org/xapi", stmt.GetUri());
            Assert.AreEqual("de", stmt.GetLanguage());
            Assert.AreEqual("TestPlatform", stmt.GetPlatform());
            Assert.AreEqual(registration, stmt.GetRegistration());
            Assert.AreEqual("Teacher", stmt.GetInstructor()?.Name);
            Assert.AreEqual("Other Author", stmt.GetAuthority().Name);

            // Act
            stmt.ChangeObject(xapi.systemControl.activities.stage);
            stmt.SetOrigin("https://origin.example.org");

            // Assert
            Assert.IsTrue(stmt.HasActivityKey("stage"));
            Assert.AreEqual("https://origin.example.org", stmt.GetOrigin());
        }

        [Test]
        public void xApiStatement_Tests_Extensions_Can_Be_Added_And_Dropped()
        {
            // Arrange
            var stmt = CreateStatement();

            // Act
            stmt.WithExtension(xapi.systemControl.extensions.activity.name("Game"))
                .WithContext(xapi.systemControl.extensions.context.fps(60))
                .WithResult(xapi.systemControl.extensions.result.language("de"));

            // Assert
            Assert.IsTrue(stmt.HasExtensionKey("name"));
            Assert.IsTrue(stmt.HasExtension("systemControl.extensions.activity.name"));
            Assert.IsTrue(stmt.HasContextKey("fps"));
            Assert.IsTrue(stmt.HasContext("systemControl.extensions.context.fps"));
            Assert.IsTrue(stmt.HasResultKey("language"));
            Assert.IsTrue(stmt.HasResult("systemControl.extensions.result.language"));

            // Act
            stmt.DropExtensionByKey("name").DropContextKey("fps").DropResultKey("language");

            // Assert
            Assert.IsFalse(stmt.HasExtensionKey("name"));
            Assert.IsFalse(stmt.HasContextKey("fps"));
            Assert.IsFalse(stmt.HasResultKey("language"));
        }

        [Test]
        public void xApiStatement_Tests_Drop_By_Path_And_Drop_All()
        {
            // Arrange
            var stmt = CreateStatement()
                .WithExtension(xapi.systemControl.extensions.activity.name("Game"))
                .WithContext(xapi.systemControl.extensions.context.fps(60))
                .WithResult(xapi.systemControl.extensions.result.language("de"));

            // Act
            stmt.DropExtension("systemControl.extensions.activity.name")
                .DropContext("systemControl.extensions.context.fps")
                .DropResult("systemControl.extensions.result.language");

            // Assert
            Assert.AreEqual(0, stmt.GetActivityExtensions().Count);
            Assert.AreEqual(0, stmt.GetContextExtensions().Count);
            Assert.AreEqual(0, stmt.GetResultExtensions().Count);

            // Act
            stmt.WithExtension(xapi.systemControl.extensions.activity.name("Game"))
                .WithContext(xapi.systemControl.extensions.context.fps(60))
                .WithResult(xapi.systemControl.extensions.result.language("de"))
                .DropExtensions().DropContexts().DropResults();

            // Assert
            Assert.AreEqual(0, stmt.GetActivityExtensions().Count);
            Assert.AreEqual(0, stmt.GetContextExtensions().Count);
            Assert.AreEqual(0, stmt.GetResultExtensions().Count);
        }

        [Test]
        public void xApiStatement_Tests_WithValue_Routes_By_Extension_Type()
        {
            // Arrange
            var stmt = CreateStatement();

            // Act
            stmt.WithValue(xapi.systemControl.extensions.activity.name("Game"))
                .WithValue(xapi.systemControl.extensions.context.fps(60))
                .WithValue(xapi.systemControl.extensions.result.language("de"));

            // Assert
            Assert.IsTrue(stmt.HasExtensionKey("name"));
            Assert.IsTrue(stmt.HasContextKey("fps"));
            Assert.IsTrue(stmt.HasResultKey("language"));
        }

        [Test]
        public void xApiStatement_Tests_Result_Fields()
        {
            // Arrange
            var stmt = CreateStatement();

            // Act
            stmt.WithSuccess(true).WithCompletion(false).WithResponse("42").WithDuration(1.5f);

            // Assert
            Assert.AreEqual(true, stmt.GetSuccess());
            Assert.AreEqual(false, stmt.GetCompletion());
            Assert.AreEqual("42", stmt.GetResponse());
            Assert.AreEqual(TimeSpan.FromSeconds(1.5), stmt.GetDuration());
            Assert.AreEqual("PT1.5S", stmt.GetDurationString());

            // Act
            stmt.WithDuration(TimeSpan.FromMinutes(2));
            Assert.AreEqual("PT2M", stmt.GetDurationString());
            stmt.WithDuration(Duration.FromHours(1));
            Assert.AreEqual("PT1H", stmt.GetDurationString());
            stmt.DropSuccess().DropCompletion().DropResponse();

            // Assert
            Assert.IsNull(stmt.GetSuccess());
            Assert.IsNull(stmt.GetCompletion());
            Assert.IsNull(stmt.GetResponse());
        }

        [Test]
        public void xApiStatement_Tests_WithScore_Scales_Raw_Value()
        {
            // Act
            var stmt = CreateStatement().WithScore(8, 0, 10);

            // Assert
            Assert.AreEqual(8, stmt.GetScore().raw);
            Assert.AreEqual(0, stmt.GetScore().min);
            Assert.AreEqual(10, stmt.GetScore().max);
            Assert.AreEqual(0.8, stmt.GetScore().scaled.Value, 1e-9);
        }

        [Test]
        public void xApiStatement_Tests_WithScore_Rejects_Zero_Max_And_Can_Be_Dropped()
        {
            // Arrange
            var stmt = CreateStatement();

            // Assert
            Assert.Throws<ArgumentException>(() => stmt.WithScore(1, 0, 0));
            Assert.IsNull(stmt.WithScore(1, 0, 2).DropScore().GetScore());
        }

        [Test]
        public void xApiStatement_Tests_Group_Members()
        {
            // Arrange
            var stmt = CreateStatement();
            var a = new xAPI_Actor("A", "a@omilaxr.dev");
            var b = new xAPI_Actor("B", "b@omilaxr.dev");

            // Act
            stmt.AddToGroup(a, b);

            // Assert
            Assert.IsTrue(stmt.IsInGroup);
            CollectionAssert.AreEqual(new[] { a, b }, stmt.GetGroupMembers());

            // Act
            stmt.RemoveFromGroup(new xAPI_Actor("A", "a@omilaxr.dev"));

            // Assert
            CollectionAssert.AreEqual(new[] { b }, stmt.GetGroupMembers());

            // Act
            stmt.DropGroup();

            // Assert
            Assert.IsFalse(stmt.IsInGroup);
            Assert.IsEmpty(stmt.GetGroupMembers());
        }

        [Test]
        public void xApiStatement_Tests_Team_Members()
        {
            // Arrange
            var stmt = CreateStatement();
            var team = new xAPI_Actor("Team", "team@omilaxr.dev");
            var a = new xAPI_Actor("A", "a@omilaxr.dev");
            var b = new xAPI_Actor("B", "b@omilaxr.dev");

            // Act
            stmt.WithTeam(team).AddToTeam(a, b).RemoveFromTeam(b);

            // Assert
            Assert.AreEqual("Team", stmt.GetTeam()?.Name);
            CollectionAssert.AreEqual(new[] { a }, stmt.GetTeamMembers());

            // Act
            stmt.DropTeam();

            // Assert
            Assert.IsEmpty(stmt.GetTeamMembers());
        }

        [Test]
        public void xApiStatement_Tests_References_And_Discard()
        {
            // Arrange
            var first = CreateStatement();
            var second = CreateStatement();
            var refId = Guid.NewGuid();

            // Act
            second.WithRef(first);

            // Assert
            Assert.AreEqual(first.GetId(), second.GetRefId());
            Assert.AreEqual(refId, second.WithRef(refId).GetRefId());

            // Act
            second.Discard();

            // Assert
            Assert.IsTrue(second.IsDiscarded());
        }

        [Test]
        public void xApiStatement_Tests_Timestamp_And_Correct_Responses()
        {
            // Arrange
            var timestamp = new DateTime(2025, 3, 4, 5, 6, 7, 8, DateTimeKind.Utc);

            // Act
            var stmt = CreateStatement()
                .WithTimestamp(timestamp)
                .WithInteractionType(TinCan.InteractionType.Choice)
                .WithCorrectResponses("a", "b");

            // Assert
            Assert.AreEqual(timestamp, stmt.GetTimestamp());
            Assert.AreEqual("2025-03-04T05:06:07.008Z", stmt.GetTimestampString());
            Assert.AreEqual(TinCan.InteractionType.Choice, stmt.GetInteractionType());
            CollectionAssert.AreEqual(new[] { "a", "b" }, stmt.GetCorrectResponses());
            Assert.IsEmpty(stmt.WithCorrectResponses().GetCorrectResponses());
            Assert.IsEmpty(stmt.WithCorrectResponses((System.Collections.Generic.List<string>)null).GetCorrectResponses());
        }

        [Test]
        public void xApiStatement_Tests_Clone_Copies_All_Fields()
        {
            // Arrange
            var original = CreateStatement()
                .WithExtension(xapi.systemControl.extensions.activity.name("Game"))
                .WithContext(xapi.systemControl.extensions.context.fps(60))
                .WithResult(xapi.systemControl.extensions.result.language("de"))
                .WithSuccess(true)
                .WithScore(5, 0, 10)
                .WithDuration(2f)
                .WithInteractionType(TinCan.InteractionType.Choice)
                .WithCorrectResponses("a")
                .WithRef(Guid.NewGuid())
                .AddToGroup(new xAPI_Actor("A", "a@omilaxr.dev"));

            // Act
            var clone = (xApiStatement)original.Clone();

            // Assert
            Assert.AreNotEqual(original.GetId(), clone.GetId());
            Assert.IsTrue(clone.MatchKeys("started", "game"));
            Assert.IsTrue(clone.HasExtensionKey("name"));
            Assert.IsTrue(clone.HasContextKey("fps"));
            Assert.IsTrue(clone.HasResultKey("language"));
            Assert.AreEqual(true, clone.GetSuccess());
            Assert.AreEqual(5, clone.GetScore().raw);
            Assert.AreEqual(1, clone.GetGroupMembers().Length);
            Assert.AreEqual(original.GetDuration(), clone.GetDuration());
            Assert.AreEqual(original.GetInteractionType(), clone.GetInteractionType());
            CollectionAssert.AreEqual(original.GetCorrectResponses(), clone.GetCorrectResponses());
            Assert.AreEqual(original.GetRefId(), clone.GetRefId());
        }

        [Test]
        public void xApiStatement_Tests_Clone_Is_Independent()
        {
            // Arrange
            var original = CreateStatement().AddToGroup(new xAPI_Actor("A", "a@omilaxr.dev"));
            var clone = (xApiStatement)original.Clone();

            // Act
            clone.DropGroup().WithExtension(xapi.systemControl.extensions.activity.name("Game"));

            // Assert
            Assert.AreEqual(1, original.GetGroupMembers().Length);
            Assert.IsFalse(original.HasExtensionKey("name"));
        }

        [Test]
        public void xApiStatement_Tests_ToJsonString_Produces_Valid_xAPI()
        {
            // Arrange
            var stmt = CreateStatement()
                .WithExtension(xapi.systemControl.extensions.activity.name("Game"))
                .WithContext(xapi.systemControl.extensions.context.fps(60))
                .WithSuccess(true)
                .WithPlatform("TestPlatform");

            // Act
            var json = JObject.Parse(stmt.ToJsonString());

            // Assert
            Assert.AreEqual(stmt.GetId().ToString(), (string)json["id"]);
            Assert.AreEqual("mailto:learner@omilaxr.dev", (string)json["actor"]["mbox"]);
            Assert.AreEqual("mailto:author@omilaxr.dev", (string)json["authority"]["mbox"]);
            Assert.AreEqual(Registry.uri + "/systemControl/verbs/started", (string)json["verb"]["id"]);
            Assert.AreEqual(Registry.uri + "/systemControl/activities/game", (string)json["object"]["id"]);
            Assert.AreEqual("Game",
                (string)json["object"]["definition"]["extensions"][Registry.uri + "/systemControl/extensions/activity/name"]);
            Assert.AreEqual(60,
                (int)json["context"]["extensions"][Registry.uri + "/systemControl/extensions/context/fps"]);
            Assert.AreEqual("TestPlatform", (string)json["context"]["platform"]);
            Assert.AreEqual(true, (bool)json["result"]["success"]);
            Assert.AreEqual(stmt.ToJsonString(), stmt.ToDataStandardString());
        }

        [Test]
        public void xApiStatement_Tests_ToJsonString_Group_Actor_And_Reference()
        {
            // Arrange
            var referenced = CreateStatement();
            var stmt = CreateStatement()
                .AddToGroup(new xAPI_Actor("A", "a@omilaxr.dev"), new xAPI_Actor("B", "b@omilaxr.dev"))
                .WithRef(referenced);

            // Act
            var json = JObject.Parse(stmt.ToJsonString());

            // Assert
            Assert.AreEqual("Group", (string)json["actor"]["objectType"]);
            Assert.AreEqual(2, ((JArray)json["actor"]["member"]).Count);
            Assert.AreEqual(referenced.GetId().ToString(), (string)json["context"]["statement"]["id"]);
        }

        [Test]
        public void xApiStatement_Tests_ToCsvFormat_Has_One_Column_Per_Statement_Part()
        {
            // Act
            var csv = CreateStatement().ToCsvFormat();

            // Assert
            CollectionAssert.AreEqual(
                new[] { "id", "version", "timestamp", "origin", "authority", "actor", "verb", "object", "context", "result" },
                csv.Headers);
            Assert.AreEqual(1, csv.Rows.Count);
            Assert.AreEqual("1.0.3", csv.Rows[0][1]);
        }

        [Test]
        public void xApiStatement_Tests_ToCsvFormat_Flatten_Uses_Relative_Ids()
        {
            // Act
            var csv = CreateStatement()
                .WithExtension(xapi.systemControl.extensions.activity.name("Game"))
                .ToCsvFormat(flatten: true);

            // Assert
            CollectionAssert.Contains(csv.Headers, "actor_mbox");
            CollectionAssert.Contains(csv.Headers, "verb_id");
            Assert.AreEqual("/systemControl/verbs/started", csv.Rows[0][csv.Headers.IndexOf("verb_id")]);
            Assert.IsTrue(csv.Headers.Any(h => h.StartsWith("object_definition_extensions")));
        }

        [Test]
        public void xApiStatement_Tests_ToShortString()
        {
            Assert.AreEqual("[xAPI Learner started game]", CreateStatement().ToShortString());
        }
    }
}
