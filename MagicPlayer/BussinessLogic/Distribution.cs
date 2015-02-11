using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class Distribution
    {
        private int[] suitsNumbers = new int[4];

        public int[] SuitsNumbers {get { return suitsNumbers; }}
        
        public Distribution(string line)
        {
            var hand = new Hand(line);
            foreach (var card in hand.Cards)
            {
                switch (card.Name)
                {
                    case Suit.Clubs:
                        suitsNumbers[0] += 1;
                        break;
                    case Suit.Diamonds:
                        suitsNumbers[1] += 1;
                        break;
                    case Suit.Hearts:
                        suitsNumbers[2] += 1;
                        break;
                    case Suit.Spades:
                        suitsNumbers[3] += 1;
                        break;
                }
            }
        }
    }
}
