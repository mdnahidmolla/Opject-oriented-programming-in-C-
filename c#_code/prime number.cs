using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i;
            Console.WriteLine("Enter a number : ");
            n = Convert.ToInt32(Console.ReadLine());

            if(n>1){
                for(i = 2;i < n; i++){
                    if(n%i == 0){
                        Console.WriteLine("Not prime : "+n);
                        break;
                    }
                    else{
                        Console.WriteLine("Prime : "+n);
                        break;
                    }
                
                }
                
            }
        }
    }
}

