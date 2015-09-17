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
            string roomName;
            int totalArea = 0;
            List<string> roomNames = new List<string>();
            List<int> lengths = new List<int>();
            List<int> widths = new List<int>();
            Console.WriteLine("Enter the Room Name, Length and Width of each room in the house, when finished enter 'Done'");
            for (int i = 1; i > 0; i++)
            {
                Console.Write("Enter the room name: ");
                roomName = Console.ReadLine();
                if (roomName.Equals("Done"))
                {
                    break;
                }
                else
                {
                    roomNames.Add(roomName);
                }
                Console.Write("Enter the room length: ");
                lengths.Add(int.Parse(Console.ReadLine()));
                Console.Write("Enter the room width: ");
                widths.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine();
            Console.WriteLine(String.Format("{0, -20} {1,-10}", "Room", "Area"));
            for (int i = 0; i < lengths.Count; i++)
            {
                int area = lengths[i] * widths[i];
                totalArea += area;
                Console.WriteLine(String.Format("{0,-20} {1,-10}", roomNames[i], area));
            }
            Console.WriteLine();
            Console.WriteLine(String.Format("{0,-20} {1,-10}", "Total", totalArea));
            Console.ReadKey();
        }
    }
}
