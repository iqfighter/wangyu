using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxiBilling;
namespace TaxiBillingTests
{
    [TestClass]
    public class TestBillingTests
    {
        private readonly TaxiBilling.TaxiBilling _sut = new TaxiBilling.TaxiBilling();
        [TestMethod]public void Given_Distance_Should_Return_By_Unit_Price_Test()
        {
            Assert.AreEqual(4, _sut.Bill(5));
        }

        [TestMethod]
        public void Given_Long_Distance_Should_Return_With_Extra_Charge_Test()
        {
            Assert.AreEqual(7.6, _sut.Bill(9));
        }
    }
}
