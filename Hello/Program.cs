using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            Console.WriteLine("Enter numbers to add up, separated by a single comma (,)");
            string s = (Console.ReadLine());
            string[] numbers = s.Split(',');

            int[] convertedItems = Array.ConvertAll<string, int>(numbers, int.Parse);

            for (int i = 0; i < convertedItems.Length; i++)
            {
                total += convertedItems[i];
            }

            Console.WriteLine("The total is " + total);
            Console.ReadKey();
        }
    }
}
