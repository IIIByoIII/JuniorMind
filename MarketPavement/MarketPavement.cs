using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarketPavement
{
    [TestClass]
    public class MarketPavement
    {
        [TestMethod]
        public void TotalTilesNeeded()
        {
            int numberOfTilesNeeded = TotalNumberOfTiles(25, 10, 6);
            Assert.AreEqual(10, numberOfTilesNeeded);
        }

        int TotalNumberOfTiles (double marketLenght, double marketWidth, double tileDimension)
        {
            double tilesPerLength = marketLenght / tileDimension;
            int tilesPerLengthRounded = (int)Math.Ceiling(tilesPerLength);
            double tilesPerWidth = marketWidth / tileDimension;
            int tilesPerWidthRounded = (int)Math.Ceiling(tilesPerWidth);
            int tilesNeeded = tilesPerLengthRounded * tilesPerWidthRounded;
            return tilesNeeded;
        }
    }
}
