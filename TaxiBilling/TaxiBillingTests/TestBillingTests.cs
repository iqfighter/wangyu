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
            Assert.AreEqual(8, _sut.Bill(9));
        }

        [TestMethod]
        public void Given_Less_Than_StartDistance_Should_Return_StartPrice()
        {
            Assert.AreEqual(_sut.StartPrice, _sut.Bill(1));
        }

        [TestMethod]
        public void Given_Waiting_Time_Should_Return_Both_Waiting_And_Distance_Price()
        {
            Assert.AreEqual(6, _sut.Bill(1, 1));
        }

        [TestMethod]
        public void Given_Long_Distance_Waiting_Time_Should_Return_Both_Waiting_And_Distance_Price()
        {
            Assert.AreEqual(17, _sut.Bill(15, 8));
        }

        [TestMethod]
        public void Should_Return_Round_Price()
        {
            Assert.AreEqual(6, _sut.Bill(7));
        }

        [TestMethod]
        public void Given_Invalid_Input_Should_Return_0()
        {
            Assert.AreEqual(0, _sut.Bill(-3, -2));
        }

    }
}
