using Handitia_Test.Logic;
using System;

namespace Handitia_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            PrintNumber();
        }

        static void PrintNumber()
        {
            for (int i = 1; i <= 100; i++)
            {
                OutputHandler handler = new OutputHandler();
                Console.WriteLine(handler.Output(i));
            }
        }
    }
}
