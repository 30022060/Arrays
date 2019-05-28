using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] names;
            names = new string[5];

            Console.Write("Enter Name 1: ");
            names[0] = Console.ReadLine();
            Console.Write("Enter Name 2: ");
            names[1] = Console.ReadLine();
            Console.Write("Enter Name 3: ");
            names[2] = Console.ReadLine();
            Console.Write("Enter Name 4: ");
            names[3] = Console.ReadLine();
            Console.Write("Enter Name 5: ");
            names[4] = Console.ReadLine();

            Console.WriteLine($"First Name on the list: {names[0]}");
            Console.WriteLine($"Last Name on the list: {names[4]}");

            Console.ReadLine();
        }
    }
}
