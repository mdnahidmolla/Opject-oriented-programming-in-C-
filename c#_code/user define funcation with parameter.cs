
using System;

namespace C_
{
    class Program
    {
        public static void hi(string name){
            Console.WriteLine("Hello "+name+" How are you?");
        }
        public static void well(string name){
            Console.WriteLine(name+" I am well.");
        }
        static void Main(string[] args)
        {
            string n;
            Console.Write("Enter a man name : ");
            n = Console.ReadLine();
            hi(n);
            well(n);
            Console.ReadKey();
        }
    }
}

