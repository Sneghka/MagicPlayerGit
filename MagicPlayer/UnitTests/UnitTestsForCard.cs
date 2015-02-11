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
    public class UnitTestsForCard
    {
        [Test]
        public void CardName()
        {
            var input = "10C";
            var card = new Card(input);
            var output = card.Name;
            Assert.AreEqual(Suit.Clubs, output);
        }

        [Test]
        public void CardValue()
        {
            var input = "JC";
            var card = new Card(input);
            var output = card.Value;
            Assert.AreEqual(Strength._J, output);
        }

        [Test]
        public void CardValue1()
        {
            var input = "2C";
            var card = new Card(input);
            var output = card.Value;
            Assert.AreEqual(Strength._2, output);
        }

        [Test]
        public void CardFoIsNull()
        {
            var input = "5C";
            var card = new Card(input);
            var output = card.GetHCPForCard();
            Assert.AreEqual(0, output);
        }
        [Test]
        public void CardFoIsNotNull()
        {
            var input = "AC";
            var card = new Card(input);
            var output = card.GetHCPForCard();
            Assert.AreEqual(4, output);
        }
    }
}
