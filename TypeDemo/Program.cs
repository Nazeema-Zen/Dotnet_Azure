using System;

namespace TypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integer type
            int age = 30;

            // Floating-point type
            double height = 5.9;

            // Decimal type
            decimal salary = 55000.75m;

            // Character type
            char grade = 'A';

            // Boolean type
            bool isActive = true;

            // String reference type
            string employeeName = "Amit Sharma";

            Console.WriteLine("Employee Information");
            Console.WriteLine("--------------------");

            Console.WriteLine("Name: " + employeeName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Active: " + isActive);

            Console.WriteLine("\nData Types:");
            Console.WriteLine("Age Type: " + age.GetType());
            Console.WriteLine("Height Type: " + height.GetType());
            Console.WriteLine("Salary Type: " + salary.GetType());
            Console.WriteLine("Grade Type: " + grade.GetType());
            Console.WriteLine("Active Type: " + isActive.GetType());
            Console.WriteLine("Name Type: " + employeeName.GetType());
        }
    }
}