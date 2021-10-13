using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.Write("What's your name?");
            string name = Console.ReadLine();
            Console.Write("nice to meet you, ");
            Console.WriteLine(name);
            Console.WriteLine("Press any key to go further...");
            Console.ReadLine();

        }
    }
}
