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
            int repetitionsToDo = TotalRepetitions(6);
            Assert.AreEqual(36, repetitionsToDo);
        }

        int TotalRepetitions (int numberOfRounds)
        {
            int totalNumberOfRepetitions = numberOfRounds * numberOfRounds;
            return totalNumberOfRepetitions;
        }
    }
}
