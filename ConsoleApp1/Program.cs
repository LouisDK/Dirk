using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello Piet, 2 + 2 is {add(2,2)}");
        }
        static int add(int a, int b) {
            return a + b + 10;
        }
    }
}
