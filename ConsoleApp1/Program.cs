using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello Koos, 2 + 2 is {add(2,2)}");
        }
        static int add(int a, int b) {
            return a + b;
        }
    }
}
