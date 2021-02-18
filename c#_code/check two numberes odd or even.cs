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

           if((a%2 == 0) && (b%2 == 0)){
               Console.WriteLine("number is Even");
           }
           else{
               Console.WriteLine("number is Odd");
           }
           Console.ReadKey();
            
        }
    }
}

