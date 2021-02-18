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

           for(n = 1; n <= m; n++){
               sum += n;
           }
           Console.WriteLine("first to m numbers sum = "+sum);
           Console.ReadKey();
            
        }
    }
}

