using NUnit.Framework;
namespace Test
{
    [TestFixture]
    public class DummyTest : TestBase
    {
        [Test]
        public void Test()
        {
            resources.InfoResource.SendRequestAndValidateResponse();
        }
    }
}