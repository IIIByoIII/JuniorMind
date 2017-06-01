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
            decimal birdFlyDistance = CalculateBirdFlyDistance(60);
            Assert.AreEqual(20, birdFlyDistance);
        }

        [TestMethod]
        public void SummedFlyDistanceOfBird()
        {
            decimal sumOfBirdFlyDistance = CalculateSumOfDistances(243, 4);
            Assert.AreEqual(120, sumOfBirdFlyDistance);
        }

        decimal CalculateBirdFlyDistance(decimal trainDistance)
        {
            // (trainDistance/2)*(2/3)
            return trainDistance / 3;
        }

        decimal CalculateSumOfDistances(decimal trainDistance, int timesBirdFlown)
        {
            decimal remainingDistance = trainDistance / 3;
            decimal currentDistanceFlown = remainingDistance;
            for (int i = 1; i < timesBirdFlown; i++)
            {
                remainingDistance = remainingDistance / 3;
                currentDistanceFlown += remainingDistance;
            }
            return currentDistanceFlown;
        }
    }
}
