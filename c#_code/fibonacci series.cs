using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i,first = 0,second = 1,m;
            Console.WriteLine("Enter a number : ");
            n = Convert.ToInt32(Console.ReadLine());

            for(i = 3;i <= n;i++){
                m = first + second;
                first = second;
                second = m;
                Console.Write(" {0} ",m);
            }
            Console.ReadKey();
        }


    }
}

