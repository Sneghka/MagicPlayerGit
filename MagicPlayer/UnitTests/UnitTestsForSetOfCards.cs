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
            var output = cards.GetFo();
            Assert.AreEqual(0, output);
        }
        
        [Test]
        public void CardFoIsNotNull()
        {
            var input = "AC";
            var cards = new SetOfCards(input);
            var output = cards.GetFo();
            Assert.AreEqual(4, output);
        }

        [Test]
        public void Card()
        {
            var input = "AC 2D";
            var cards = new SetOfCards(input);
            var output = cards.GetFo();
            Assert.AreEqual(4, output);
        }

        [Test]
        public void Card1()
        {
            var input = "AC KD 3H";
            var cards = new SetOfCards(input);
            Assert.AreEqual(7, cards.GetFo());
        }
    }
}
