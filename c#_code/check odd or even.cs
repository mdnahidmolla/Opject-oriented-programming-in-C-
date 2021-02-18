using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("enter a = ");
            a = Convert.ToInt32(Console.ReadLine());

           if(a%2 == 0){
               Console.WriteLine("number is Even");
           }
           else{
               Console.WriteLine("number is Odd");
           }
           Console.ReadKey();
            
        }
    }
}

