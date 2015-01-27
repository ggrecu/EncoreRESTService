using Encore.REST.Model.Entities;
using Encore.REST.Model.Entities.Mock;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncoreRESTService.Tests
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            Genre[] genre =  {};
            genre = genre.Mock();
            Assert.IsNotNull(genre);
        }
    }
}
