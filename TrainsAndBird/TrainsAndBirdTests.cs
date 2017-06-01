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
        public void FirstAndSecondFlyDistanceOfBird()
        {
            decimal sumOfBirdFlyDistance = CalculateSumOfDistances(90, 2);
            Assert.AreEqual(40, sumOfBirdFlyDistance);
        }

        decimal CalculateBirdFlyDistance(decimal trainDistance)
        {
            // (trainDistance/2)*(2/3)
            return trainDistance / 3;
        }

        decimal CalculateSumOfDistances(decimal trainDistance, int timesBirdFlown)
        {
            decimal currentDistanceFlown = trainDistance / 3;
            for (int i = 1; i < timesBirdFlown; i++)
            {
                currentDistanceFlown += currentDistanceFlown / 3;
            }
            return currentDistanceFlown;
        }
    }
}
