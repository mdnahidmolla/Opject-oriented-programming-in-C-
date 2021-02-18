
using System;

namespace C_
{
    class Program
    {
        public static void swap(ref int a,ref int b){
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
       
        static void Main(string[] args)
        {
            int a,b;
            Console.Write("Enter a first num :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number :");
            b = Convert.ToInt32(Console.ReadLine());
            swap(ref a,ref b);
            Console.WriteLine("first num {0} \n second num {1}",a,b);
            Console.ReadKey();
        }
    }
}

