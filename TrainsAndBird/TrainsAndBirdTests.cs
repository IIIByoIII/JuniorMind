using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrainsAndBird
{
    //    Două trenuri pornesc în același timp unul către celălalt cu o viteză constantă de X km/h.
    //Când cele două trenuri au parcurs o pătrime din distanța inițială, o pasăre aflată pe primul tren pornește în zbor către al 2-lea tren cu o viteză de 2X.
    //Imediat ce a ajuns la el se întoarce către primul și repetă asta până când cele două trenuri se întâlnesc.
    //Care e distanța zburată de pasăre?
    [TestClass]
    public class TrainsAndBirdTests
    {
        [TestMethod]
        public void FirstFlyDistanceOfBird()
        {
            double birdFlyDistance = CalculateBirdFlyDistance(60);
            Assert.AreEqual(20, birdFlyDistance);
        }

        [TestMethod]
        public void SummedFlyDistanceOfBird()
        {
            double sumOfBirdFlyDistance = CalculateSumOfDistances(243, 6);
            Assert.AreEqual(121.333333, sumOfBirdFlyDistance, 0.001);
        }

        double CalculateBirdFlyDistance(double trainDistance)
        {
            // (trainDistance/2)*(2/3)
            return trainDistance / 3;
        }

        double CalculateSumOfDistances(double trainDistance, int timesBirdFlown)
        {
            double remainingDistance = trainDistance / 3;
            double currentDistanceFlown = remainingDistance;
            for (int i = 1; i < timesBirdFlown; i++)
            {
                remainingDistance = remainingDistance / 3;
                currentDistanceFlown += remainingDistance;
            }
            return currentDistanceFlown;
        }
    }
}
