
using System;

namespace C_
{
    class Program
    {
        public static int fact(int n){
            if(n == 0){
                return 1;
            }
            else{
                return n*fact(n-1);
            }
        }
       
        static void Main(string[] args)
        {
            int a;
            Console.Write("Enter a number :");
            a = Convert.ToInt32(Console.ReadLine());
            int b = fact(a);
            Console.WriteLine("Factorial num is = {0}",b);
            Console.ReadKey();
        }
    }
}

