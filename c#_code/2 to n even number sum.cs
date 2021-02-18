using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
           int n,m,sum = 0;
            Console.WriteLine("Enter a number : ");
            n = Convert.ToInt32(Console.ReadLine());

           for(m = 2; m <= n; m=m+2){
               sum += m;
           }
           Console.WriteLine("1 to n even number sum = "+sum);
           Console.ReadKey();
            
        }
    }
}

