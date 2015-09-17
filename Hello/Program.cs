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
            Console.WriteLine("Please enter your name");
            String name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Press return to exit");
            Console.ReadKey();
        }
    }
}
