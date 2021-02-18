using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            char n;
            Console.WriteLine("Enter an alphabet : ");
            n = Convert.ToChar(Console.ReadLine().ToLower());
            if(n == 'a' || n == 'e' || n == 'o' ||n == 'i' || n == 'u'){
                Console.WriteLine("Vowel");
            }
            else{
                Console.WriteLine("Consonant");
            }
           Console.ReadKey();
            
        }
    }
}

