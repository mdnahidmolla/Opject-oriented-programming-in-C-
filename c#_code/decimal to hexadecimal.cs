using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
           int n;
            Console.WriteLine("Enter a decimal number : ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Hexadecimal number = {0:x}",n);
            Console.ReadKey();
            
        }
    }
}

