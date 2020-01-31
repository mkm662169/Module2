using System;
using ConsoleUtilities;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            string stringOutput = "Hello World!";
            string output = utilities.WriteLine(stringOutput);
            Console.ReadKey();
        }
    }
}
