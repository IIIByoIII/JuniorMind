using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HungryGoats
{
    //    În X zile Y capre mănâncă Z kg fân.
    //Câte kg de fân mănâncă Q capre în W zile?
    [TestClass]
    public class HungryGoats
    {
        [TestMethod]
        public void HayEatenByGoats()
        {
            double hayEaten = CalculateEatenHay(2, 2, 4.0, 3, 3);
            Assert.AreEqual(9.0, hayEaten);
        }

        double CalculateEatenHay(int xDays, int yGoats, double zHay, int wDays, int qGoats)
        {
            double hayEatenPerGoatPerDay = zHay / yGoats / xDays;
            double hayForQGoatsInWDays = hayEatenPerGoatPerDay * qGoats * wDays;
            return hayForQGoatsInWDays;
        }
    }
}
