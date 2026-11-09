using NUnit.Framework;

namespace OmiLAXR.xAPI.Tests
{
    public class xApiRegistry_Tests
    {
        [TestCase("https://xapi.elearn.rwth-aachen.de/definitions")]
        [TestCase("https://xapi.elearn.rwth-aachen.de/definitions/")]
        public void ToCurrentUri_Replaces_Former_Default_Base(string former)
        {
            // Arrange / Act
            var result = xApiRegistry.ToCurrentUri(former);

            // Assert
            Assert.AreEqual(xApiRegistry.DefaultUri, result);
        }

        [TestCase("https://omilaxr-ecosystem.github.io/xapi/definitions")]
        [TestCase("https://lrs.example.org/my-definitions")]
        [TestCase("")]
        [TestCase(null)]
        public void ToCurrentUri_Keeps_Other_Values(string value)
        {
            // Arrange / Act
            var result = xApiRegistry.ToCurrentUri(value);

            // Assert
            Assert.AreEqual(value, result);
        }

        [Test]
        public void DefaultUri_Is_The_GitHub_Pages_Registry()
        {
            // Arrange / Act
            var uri = xApiRegistry.DefaultUri;

            // Assert
            Assert.AreEqual("https://omilaxr-ecosystem.github.io/xapi/definitions", uri);
        }
    }
}
