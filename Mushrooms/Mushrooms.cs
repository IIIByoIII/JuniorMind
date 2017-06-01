using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mushrooms
{
    [TestClass]
    public class Mushrooms
    {
        [TestMethod]
        public void NumberOfRedMushrooms()
        {
            int redMushrooms = CalculateRedMushrooms(10, 3);
            Assert.AreEqual(7, redMushrooms);
        }

        int CalculateRedMushrooms(int totalNumberOfMushrooms, int timesMoreRedMushrooms)
        {
            int redMushrooms = timesMoreRedMushrooms * totalNumberOfMushrooms / (1 + timesMoreRedMushrooms);
            return redMushrooms;
        }
    }
}
