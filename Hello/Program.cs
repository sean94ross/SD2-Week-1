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
            int num = 0;
            bool isPrime = true;
            List<int> primeNumbers = new List<int>();
            for (int i = 1; i > 0; i++)
            {
                Console.WriteLine("Please enter a number between 1 and 10,000");
                num = int.Parse(Console.ReadLine());
                if (num > 1 && num < 10000)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            for (int j = 2; j < num; j++)
            {
                if (j <= 3)
                {
                    primeNumbers.Add(j);
                }
                else
                {
                    int boundary = (int)Math.Floor(Math.Sqrt(j));

                    for (int k = 2; k <= boundary; ++k)
                    {
                        if (j % k == 0)
                        {
                            isPrime = false;
                            break;
                        }
                        else
                        {
                            isPrime = true;
                        }
                    }
                    if (isPrime == true)
                    {
                        primeNumbers.Add(j);
                    }
                }
            }
            Console.Write("These are all the prime numbers between 1 and " + num + ": ");
            for (int i = 0; i < primeNumbers.Count; i++)
            {
                Console.Write(primeNumbers[i] + ", ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
