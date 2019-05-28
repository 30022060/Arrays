using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {


            string[] place;

            place = new string[3];
            Console.Write("Enter the First place winner: ");
            place[0] = Console.ReadLine();
            Console.Write("Enter the Second place winner: ");
            place[1] = Console.ReadLine();
            Console.Write("Enter the Third place winner: ");
            place[2] = Console.ReadLine();

            Console.WriteLine("Please enter a number (1 - 3) to view medal winner: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine($"Winner of this place medal: {place[input - 1]}");
            Console.ReadLine();
        }
    }
}
