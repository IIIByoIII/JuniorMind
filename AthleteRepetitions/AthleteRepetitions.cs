using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AthleteRepetitions
{
    [TestClass]
    public class AthleteRepetitions
    {
        [TestMethod]
        public void RepetitionsDone()
        {
            int repetitionsToDo = TotalRepetitions(3);
            Assert.AreEqual(9, repetitionsToDo);
        }

        int TotalRepetitions (int numberOfRounds)
        {
            int currentNumberOfRepetitions = 0;
            for (int i = 1; i < numberOfRounds; i++)
            {
                currentNumberOfRepetitions += 2 * i;
            }
            int totalNumberOfRepetitions = currentNumberOfRepetitions + numberOfRounds;
            return totalNumberOfRepetitions;
        }
    }
}
