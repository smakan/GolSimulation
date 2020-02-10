namespace badlife.csharp.test
{
    using System.Collections.Specialized;
    using NUnit.Framework;

    public class AppConfigurationFixture
    {
        [Test]
        public void Test_InputPath_from_config()
        {
            var appSettings = new NameValueCollection { { "InputPath", "testPath" } };
            Assert.AreEqual("testPath", new AppConfiguration(appSettings).InputPath);
        }

    }
}