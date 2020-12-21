using FirstTestProject.Repository;
using FirstTestProject.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FirstTestProject.Tests
{
    [TestClass]
    public class TaxServiceShould
    {
        [TestMethod]
        public void Return1805IfGrossSalaaryIs9500()
        {
            var taxService = new TaxService(new RangeRepository());
            Assert.AreEqual(1805,taxService.GetTax(9500));
        }
        [TestMethod]
        public void Return4680IfGrossSalaaryIs19500()
        {
            var taxService = new TaxService(new RangeRepository());
            Assert.AreEqual(4680, taxService.GetTax(19500));
        }
    }
}
