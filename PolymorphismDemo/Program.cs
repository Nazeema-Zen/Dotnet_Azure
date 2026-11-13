
using System;

namespace PolymorphismDemo
{
    class Calculator
    {
        // Add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Add three integers
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Add two decimal numbers
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Two Integers: " +
                calc.Add(10, 20));

            Console.WriteLine("Three Integers: " +
                calc.Add(10, 20, 30));

            Console.WriteLine("Two Doubles: " +
                calc.Add(10.5, 20.5));
        }
    }
}

using System;

namespace PolymorphismDemo
{
    class Calculator
    {
        // Add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Add three integers
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Add two decimal numbers
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Two Integers: " +
                calc.Add(10, 20));

            Console.WriteLine("Three Integers: " +
                calc.Add(10, 20, 30));

            Console.WriteLine("Two Doubles: " +
                calc.Add(10.5, 20.5));
        }
    }
}
 