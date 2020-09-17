using System;
using FirstLib;

namespace FirstCoreProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Calculator cal = new Calculator();
            System.Console.WriteLine(cal.add(3,4));
        }
    }
}
