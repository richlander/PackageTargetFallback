using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var val = ClassLibrary1.Class1.Test1();
            Console.WriteLine($"Messenger: {val.m.ToString()}; Cimbalino: {val.p.X.ToString()}");
            
        }
    }
}