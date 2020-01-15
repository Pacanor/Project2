using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatZScore;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatZScore.Tests
{
    [TestClass()]
    public class FindZScoreTests
    {
        public static FindZScore fZScore = new FindZScore();
        private readonly int[] values = { 1, 2, 3, 4, 5 };
        private readonly int score = 4;
        private readonly double[] doubleVal = { 1.1, 2.2, 3.3, 4.4, 5.5 };
        private readonly double doubleScore = 2.2;

        [TestMethod()]
        public void ZScoreIntTest()
        {
            var z = fZScore.ZScore(score, values);
            Assert.AreEqual(0.70711, Math.Round(z, 5, MidpointRounding.ToEven));
        }

        [TestMethod()]
        public void ZScoreDoubleTest()
        {
            var z = fZScore.ZScore(doubleScore, doubleVal);
            Assert.AreEqual(-0.70711, Math.Round(z, 5, MidpointRounding.ToEven));
        }
    }
}