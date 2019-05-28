using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] english = {"Hello", "Welcome", "Love", "Meeting", "Gift" };
            string[] maori = { "Ki Ora", "Nau Mai", "Aroha", "Hui", "Koha" };

            Console.WriteLine("This app can translate english words to maori");
            for (int i = 0; i < maori.Length; i++)
            {
                Console.WriteLine($" {i+1}. {english[i]}");
            }
            Console.WriteLine("Select a word (by No.) to be translated: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine($"{english[input-1]} is translated to {maori[input-1]}");
            Console.ReadLine();
                    
        }
    }
}
