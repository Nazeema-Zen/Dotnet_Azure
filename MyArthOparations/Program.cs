using System;

namespace MyArthOparations
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter First Number : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter Second Number : ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Addition of {a} and {b} is: {a + b}");
            Console.WriteLine($"Subtraction of {a} and {b} is: {a - b}");
            Console.WriteLine($"Multiplication of {a} and {b} is: {a * b}");
            Console.WriteLine($"Modulus of {a} and {b} is: {a % b}");
        }
    }
}