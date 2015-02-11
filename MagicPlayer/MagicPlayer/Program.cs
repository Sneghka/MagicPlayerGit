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

        public static bool AreEqual(List<int> list_1, List<int> list_2)
        {
            if (list_1.Count != list_2.Count) return false;
            for (int i = 0; i < list_1.Count; i++)
                if (list_1[i] != list_2[i]) return false;
            return true;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Enter set of cards");
            //string line = Console.ReadLine();
            string line = "2H 3H 4H 5H 10C 8C 5C 2C AD KD QD AS 2S";
            var setOfCards = new SetOfCards(line);
            var hcp = setOfCards.GetHCPSetOfCards();
            var distribution = setOfCards.GetDistribution();
            //int[] d = distribution.ToArray();
            //int[] list_1 = {3, 3, 3, 4};
            //int[] list_2 = {2, 3, 3, 4};

            var list_1 = new List<int>();
            list_1.Add(3);
            list_1.Add(3);
            list_1.Add(3);
            list_1.Add(4);
            var list_2 = new List<int>();
            list_2.Add(2);
            list_2.Add(3);
            list_2.Add(4);
            list_2.Add(4);

            if ((hcp >= 12 && hcp <= 15) && (AreEqual(list_1, distribution) || AreEqual(list_2, distribution)))
                Console.WriteLine("Рука подходит для 1БК");
            else Console.WriteLine("Рука не подходит для 1БК, ФО = {0}", hcp);
            //foreach(var number in d)
            //    Console.WriteLine(number);
           
            Console.ReadKey();
        }
    }
}
