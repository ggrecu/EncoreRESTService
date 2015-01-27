using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncoreRESTService.Tests
{
    [TestClass]
    public class UnitTest2
    {
        private string connectionString = @"Data Source=DEV-L02\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=True";
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1,1);
        }

    }
}
