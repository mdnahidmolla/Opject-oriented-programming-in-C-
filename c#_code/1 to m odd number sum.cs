using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
           int n,m,sum = 0;
            Console.WriteLine("Enter a number : ");
            m = Convert.ToInt32(Console.ReadLine());

           for(n = 1; n <= m; n=n+2){
               sum += n;
           }
           Console.WriteLine("1 to m odd number sum = "+sum);
           Console.ReadKey();
            
        }
    }
}

