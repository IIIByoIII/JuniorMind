using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Parquet
{
    [TestClass]
    public class Parquet
    {
        [TestMethod]
        public void NeededParquetSurface()
        {
            double surfaceOfParquetNeeded = ParquetSurfaceNeeded(5, 6);
            Assert.AreEqual(34.5, surfaceOfParquetNeeded);
        }

        double ParquetSurfaceNeeded (double roomLength, double roomWidth)
        {
            double roomSurface = roomLength * roomWidth;
            double parquetSurface = roomSurface + (roomSurface * 15 / 100);
            return parquetSurface;
        }
    }
}
