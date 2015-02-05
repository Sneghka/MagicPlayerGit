using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class SetOfCards
    {
        private List<Card> cards= new List<Card>();
        public List<Card> Cards {get { return cards; } }

        public SetOfCards(string line)
        {
            var lines = line.Split(' ');
            foreach (var str in lines)
            {
                var card = new Card(str);
                cards.Add(card);
            }
        }

        public int GetFo()
        {
            int fo = 0;
            foreach (var card in cards)
            {
                 fo  += card.Fo;

            }
            return fo;
        }
    }
}
