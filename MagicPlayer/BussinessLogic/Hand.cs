using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class Hand
    {
        private List<Card> cards = new List<Card>();
        public List<Card> Cards { get { return cards; } }

        public Hand(string line)
        {
            var lines = line.Split(' ');
            foreach (var str in lines)
            {
                var card = new Card(str);
                cards.Add(card);
            }
        }

        //public List<int> GetDistribution()
        //{
        //    var getDistribution = new List<int>();
        //    foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        //    {
        //        int i = 0;
        //        foreach (var card in Cards)
        //        {
        //            if (card.Name == suit) i++;

        //        }
        //        getDistribution.Add(i);
        //    }
        //    getDistribution.Sort();
        //    return getDistribution;
        //}


        public int GetHCPSetOfCards()
        {
            int fo = 0;
            foreach (var card in cards)
            {
                fo += card.GetHCPForCard();

            }
            return fo;
        }
    }
}
