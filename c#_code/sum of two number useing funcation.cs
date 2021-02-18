
using System;

namespace C_
{
    class Program
    {
        public static int add(int a,int b){
            int c;
            c = a+b;
            return c;
        }
       
        static void Main(string[] args)
        {
            int a,b;
            Console.Write("Enter a first num :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("add two number = {0}",add(a,b));
            Console.ReadKey();
        }
    }
}

