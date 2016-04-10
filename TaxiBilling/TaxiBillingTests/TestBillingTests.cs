using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxiBilling;
namespace TaxiBillingTests
{
    [TestClass]
    public class TestBillingTests
    {
        [TestMethod]public void Given_Distance_Should_Return_By_Unit_Price_Test()
        {
            var sut = new TaxiBilling.TaxiBilling();
            Assert.AreEqual(4, sut.Bill(5));
        }
    }
}
