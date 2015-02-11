using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public enum Suit { Clubs, Diamonds, Hearts, Spades };
    public enum Strength { _2, _3, _4, _5, _6, _7, _8, _9, _10, _J, _Q, _K, _A };

    public class Card
    {
        public const int HCP_FOR_JACK = 1;
        public const int HCP_FOR_QUEEN = 2;
        public const int HCP_FOR_KING = 3;
        public const int HCP_FOR_ACE = 4;

        public Suit Name { get; private set; }
        public Strength Value { get; private set; }

        public Card(string line)
        {
            var suitChar = line.Substring(line.Length - 1);
            switch (suitChar)
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
        }

        public int GetHCPForCard()
        {
            int fo = 0;
            switch (Value)
            {
                case Strength._J:
                    fo = HCP_FOR_JACK;
                    break;
                case Strength._Q:
                    fo = HCP_FOR_QUEEN;
                    break;
                case Strength._K:
                    fo = HCP_FOR_KING;
                    break;
                case Strength._A:
                    fo = HCP_FOR_ACE;
                    break;
                default:
                    fo = 0;
                    break;
            }
            return fo;
        }
    }
}
