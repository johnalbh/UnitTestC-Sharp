using FirstTestProject.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FirstTestProject.Tests
{
    [TestClass]
    public class TaxServiceShould
    {
        [TestMethod]
        public void Return1000IfGrossSalaaryIs9500()
        {
            var taxService = new TaxService();
            Assert.AreEqual(1000,taxService.GetTax(9500));
        }
        [TestMethod]
        public void Return2000IfGrossSalaaryIs19500()
        {
            var taxService = new TaxService();
            Assert.AreEqual(2000, taxService.GetTax(19500));
        }
    }
}
