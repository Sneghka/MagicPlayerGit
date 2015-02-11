using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLogic;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    class UnitTestsForDistribution
    {
        [Test]
        public void DistributionFourSuits()
        {
            var input = "2H 3H 4H 5H 10C 8C 5C 2C AD KD QD AS 2S";
            var distribution = new Distribution(input);
            Assert.AreEqual(4, distribution.SuitsNumbers[0]);
            Assert.AreEqual(3, distribution.SuitsNumbers[1]);
            Assert.AreEqual(4, distribution.SuitsNumbers[2]);
            Assert.AreEqual(2, distribution.SuitsNumbers[3]);
        }

        [Test]
        public void DistributionThreeSuits()
        {
            var input = "2H 3H 4H 5H 10C 8C 5C 2C AD KD QD AH 2D";
            var distribution = new Distribution(input);
            Assert.AreEqual(4, distribution.SuitsNumbers[0]);
            Assert.AreEqual(4, distribution.SuitsNumbers[1]);
            Assert.AreEqual(5, distribution.SuitsNumbers[2]);
            Assert.AreEqual(0, distribution.SuitsNumbers[3]);
        }

        [Test]
        public void DistributionOneSuits()
        {
            var input = "2H 3H 4H 5H 6H 7H 8H 9H 10H JH QH KH AH";
            var distribution = new Distribution(input);
            Assert.AreEqual(0, distribution.SuitsNumbers[0]);
            Assert.AreEqual(0, distribution.SuitsNumbers[1]);
            Assert.AreEqual(13, distribution.SuitsNumbers[2]);
            Assert.AreEqual(0, distribution.SuitsNumbers[3]);
        }

    }
}
