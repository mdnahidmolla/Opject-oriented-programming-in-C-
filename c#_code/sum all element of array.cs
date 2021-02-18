using System;

namespace C_
{
    public class Program
    {
        public static void Main()
        {
            int[] a = new int[100];
            int n,sum = 0,i;

            Console.Write("how many element store in array : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Elementes {0} of array : ",n);
            for(i = 1;i<=n;i++){
                Console.Write("elementes {0} : ",i);
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            for(i = 1;i<=n;i++){
                sum = sum + a[i];
            }
            Console.WriteLine("Sum array elementes = {0}",sum);
           
            
        }
    }
}

