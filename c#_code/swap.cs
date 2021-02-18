using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, temp;
            Console.WriteLine("enter a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b = ");
            b = Convert.ToInt32(Console.ReadLine());

            temp = a;
            a = b;
            b = temp;
            
            Console.WriteLine("after swap b = "+a);
            Console.WriteLine("after swap a = "+b);
            Console.ReadKey();
        }
    }
}

