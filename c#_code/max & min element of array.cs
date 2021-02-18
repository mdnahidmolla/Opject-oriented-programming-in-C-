using System;

namespace C_
{
    public class Program
    {
        public static void Main()
        {
            int[] a = new int[100];
            int n,i,max,min;

            Console.Write("how many element store in array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Elementes {0} of array : ",n);
            for(i = 0;i < n;i++){
                Console.Write("elementes {0} : ",i);
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            max = a[0];
            min = a[0];
            for(i = 1;i < n;i++){
                if(a[i] > max){
                    max = a[i];
                }
                if(a[i] < min){
                    min = a[i];
                }
            }

            Console.WriteLine("Maximam elementes = {0} ",max);
            Console.WriteLine("Minimum element = {0}",min);
            
        }
    }
}

