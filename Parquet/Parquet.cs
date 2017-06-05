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

        [TestMethod]
        public void NeededParquetTiles()
        {
            double tilesOfParquetNeeded = ParquetTilesNeeded(5, 6, 3, 1);
            Assert.AreEqual(12, tilesOfParquetNeeded);
        }

        int ParquetTilesNeeded(double roomLength, double roomWidth, double parquetLenght, double parquetWidth)
        {
            double totalNeededSurface = ParquetSurfaceNeeded(roomLength, roomWidth);
            double parquetSurface = parquetLenght * parquetWidth;
            int parquetTiles = (int)Math.Ceiling(totalNeededSurface / parquetSurface);
            return parquetTiles;
        }
    }
}
