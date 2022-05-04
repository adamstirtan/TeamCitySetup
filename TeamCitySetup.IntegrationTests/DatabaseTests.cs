using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TeamCitySetup.IntegrationTests
{
    [TestClass]
    public class DatabaseTests
    {
        [TestMethod]
        public void LiveDataTest()
        {
            Assert.AreEqual(0, 1 - 1);
        }
    }
}