using API;
using NUnit.Framework;
namespace Test
{
    [TestFixture]
    public abstract class TestBase
    {
        protected Resources resources;
        [SetUp]
        public void StartUpTest()
        {
            resources = new Resources();
        }
        [TearDown]
        public void EndTest()
        {
            // kill webdriver instaces
        }
    }
}
