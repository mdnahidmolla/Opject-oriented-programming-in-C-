using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
           int n,i,fac = 1;
            Console.WriteLine("Enter a number : ");
            n = int.Parse(Console.ReadLine());
            for(i = 1; i <= n;i++){
                fac = fac * i;
            }
            Console.WriteLine("factorial number = "+fac);
            Console.ReadKey();
            
        }
    }
}

