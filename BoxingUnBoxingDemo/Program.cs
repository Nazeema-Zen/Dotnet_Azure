// using System;

// class Program
// {
//     static void Main()
//     {
//         int number = 100;

//         // Boxing
//         object boxedNumber = number;

//         Console.WriteLine("Original Number: " + number);
//         Console.WriteLine("Boxed Number: " + boxedNumber);

//         // Modify original value
//         number = 200;

//         Console.WriteLine("\nAfter Changing Original:");
//         Console.WriteLine("Original Number: " + number);
//         Console.WriteLine("Boxed Number: " + boxedNumber);

//         // Unboxing
//         int unboxedNumber = (int)boxedNumber;

//         Console.WriteLine("\nAfter Unboxing:");
//         Console.WriteLine("Unboxed Number: " + unboxedNumber);
//     }
// }

using System;

class Program
{
    static void Main()
    {
        object value = 100;

        try
        {
            // Incorrect unboxing
            double result = (double)value;

            Console.WriteLine(result);
        }
        catch (InvalidCastException ex)
        {
            Console.WriteLine("Invalid Unboxing!");
            Console.WriteLine("Error Type: " + ex.GetType().Name);
        }

        // Correct unboxing followed by conversion
        int number = (int)value;

        double convertedNumber = number;

        Console.WriteLine("Converted Value: " + convertedNumber);
    }
}