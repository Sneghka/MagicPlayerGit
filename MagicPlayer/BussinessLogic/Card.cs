using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class Card
    {
        public const int FO_FOR_JACK = 1;
        public const int FO_FOR_QUEEN = 2;
        public const int FO_FOR_KING = 3;
        public const int FO_FOR_ACE = 4;

        public enum Suit { Clubs, Diamonds, Hearts, Spades };
        public enum Strength { _2, _3, _4, _5, _6, _7, _8, _9, _10, _J, _Q, _K, _A };

        public Suit Name { get; set; }
        public Strength Value { get; set; }
        public int Fo { get; set; }

        public Card(string line)
        {
            switch (line.Substring(line.Length - 1))
            {
                case "C":
                    Name = Suit.Clubs;
                    break;
                case "D":
                    Name = Suit.Diamonds;
                    break;
                case "H":
                    Name = Suit.Hearts;
                    break;
                case "S":
                    Name = Suit.Spades;
                    break;
                default:
                    Console.WriteLine("Incorret format");
                    break;
            }
           

            Value = (Strength)Enum.Parse(typeof(Strength), "_" + line.Substring(0, line.Length - 1));


            switch (line[0])
            {
                case 'J':
                    Fo = FO_FOR_JACK;
                    break;
                case 'Q':
                    Fo = FO_FOR_QUEEN;
                    break;
                case 'K':
                    Fo = FO_FOR_KING;
                    break;
                case 'A':
                    Fo = FO_FOR_ACE;
                    break;
                default:
                    Fo = 0;
                    break;
            }
        }
    }
}
