using System;

namespace Addition
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter First Number : ");
            int a=int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int b=int.Parse(Console.ReadLine());
            int sum = a+b;
            Console.WriteLine($"Sum of {a} and {b} is: {sum }");      
        }
    }
}