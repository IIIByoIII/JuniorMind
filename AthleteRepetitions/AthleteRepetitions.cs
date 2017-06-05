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
            int repetitionsToDo = TotalRepetitions(5);
            Assert.AreEqual(25, repetitionsToDo);
        }

        int TotalRepetitions (int numberOfRounds)
        {
            int totalNumberOfRepetitions = numberOfRounds * numberOfRounds;
            return totalNumberOfRepetitions;
        }
    }
}
