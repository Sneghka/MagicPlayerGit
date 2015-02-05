using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLogic;

namespace MagicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter set of cards");
            string line = Console.ReadLine();
            var setOfCards = new SetOfCards(line);
            
            Console.WriteLine("The number of FO is {0}", setOfCards.GetFo());
            Console.ReadKey();
        }
    }
}
