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
    class UnitTestsForSetOfCards
    {
        [Test]
        public void CardFoIsNull()
        {
            var input = "5C";
            var cards = new SetOfCards(input);
            var output = cards.GetHCPSetOfCards();
            Assert.AreEqual(0, output);
        }

        [Test]
        public void CardFoIsNotNull()
        {
            var input = "AC";
            var cards = new SetOfCards(input);
            var output = cards.GetHCPSetOfCards();
            Assert.AreEqual(4, output);
        }

        [Test]
        public void Card()
        {
            var input = "AC 2D";
            var cards = new SetOfCards(input);
            var output = cards.GetHCPSetOfCards();
            Assert.AreEqual(4, output);
        }

        [Test]
        public void Card1()
        {
            var input = "AC KD 3H";
            var cards = new SetOfCards(input);
            Assert.AreEqual(7, cards.GetHCPSetOfCards());
        }

        [Test]
        public void CountDistribution()
        {
            var input = "AC 2C 4H JD AD 2D 3D";
            var cards = new SetOfCards(input);
            Assert.AreEqual(0, cards.GetDistribution()[0]);
            Assert.AreEqual(1, cards.GetDistribution()[1]);
            Assert.AreEqual(2, cards.GetDistribution()[2]);
            Assert.AreEqual(4, cards.GetDistribution()[3]);
        }
    }
}
