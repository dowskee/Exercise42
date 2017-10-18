using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise42
{
    class Program:Point
    {

        static void Main(string[] args)
        {
            List<Point> Entry = new List<Point>();

            Console.WriteLine("Please enter an X coordinate:");
            int ex = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a Y coordinate:");
            int why = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a Q coordinate:");
            int queue = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a Z coordinate:");
            int zee = int.Parse(Console.ReadLine());

            Point temp = new Point(ex, why, queue, zee);

            Entry.Add(temp);

            Console.WriteLine($"You have created a point object ({ex}, {why})");

            temp.CalculateDistance();

           

        }

    }
}
