using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankRate
{
    [TestClass]
    public class BankRateTests
    {
        [TestMethod]
        public void RateForFirstMonth()
        {
            decimal rate = CalculateBankRate(200, 2, 12, 1);
            Assert.AreEqual(102, rate);
        }

        decimal CalculateBankRate(decimal total, int periodInMonths, decimal interestPerYear, int currentMonth)
        {
            decimal principal = total / periodInMonths;
            decimal exactInterestPerMonth = interestPerYear / 12 / 100;
            return principal + total * exactInterestPerMonth;
        }
    }
}
