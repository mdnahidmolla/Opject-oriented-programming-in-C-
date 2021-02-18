using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a ,b ,sum;
            Console.WriteLine("enter a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b = ");
            b = Convert.ToInt32(Console.ReadLine());
            sum = a+b;
            Console.WriteLine("sum = "+sum);
            Console.ReadKey();
            
        }
    }
}
