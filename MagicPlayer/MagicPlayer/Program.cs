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

        public static bool AreEqual(int[] list_1, int[] list_2)
        {
            if (list_1.Length != list_2.Length) return false;
            for (int i = 0; i < list_1.Length; i++)
                if (list_1[i] != list_2[i]) return false;
            return true;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Enter set of cards");
            //string line = Console.ReadLine();
            string line = "2H 3H 4H 5H 10C 8C 5C 2C AD KD QD AS 2S";
            var setOfCards = new Hand(line);
            var hcp = setOfCards.GetHCPSetOfCards();
            var distribution = new Distribution(line);
            Array.Sort(distribution.SuitsNumbers);

            int[] list_1 = { 3, 3, 3, 4 };
            int[] list_2 = { 2, 3, 4, 4 };

            if ((hcp >= 12 && hcp <= 15) && (AreEqual(list_1, distribution.SuitsNumbers) || AreEqual(list_2, distribution.SuitsNumbers)))
                Console.WriteLine("Рука подходит для 1БК");
            else Console.WriteLine("Рука не подходит для 1БК, ФО = {0}", hcp);

            Console.ReadKey();
        }
    }
}
