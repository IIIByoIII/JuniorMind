using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArchaeologicalSite
{
    [TestClass]
    public class ArchaeologicalSite
    {
        [TestMethod]
        public void SurfaceOfBuilding()
        {
            double minimumSurfaceOfBuilding = MinimumSurface (1, 1, 4, 1, 1, 4);
            Assert.AreEqual(4.5, minimumSurfaceOfBuilding);
        }

        double MinimumSurface (double columnOneX, double columnOneY, double columnTwoX, double columnTwoY, double columnThreeX, double columnThreeY)
        {
            double areaOfBuilding = (((columnOneX * columnTwoY) - (columnTwoX * columnOneY)) + ((columnTwoX * columnThreeY) - (columnThreeX * columnTwoY)) + ((columnThreeX * columnOneY) - (columnOneX * columnThreeY))) / 2;
            return areaOfBuilding;
        }
    }
}
