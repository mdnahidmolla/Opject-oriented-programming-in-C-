
using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int roll;
            double gpa;

            Console.Write("Enter student name :");
            name  = Console.ReadLine();
            Console.Write("Enter student roll num :");
            roll = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter student gpa :");
            gpa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nAll about of student.\n");
            Console.WriteLine("Student Name : "+name);
            Console.WriteLine("Student Roll : "+roll);
            Console.WriteLine("Student Gpa : "+gpa);
        }
    }
}

