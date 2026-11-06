using System;

namespace HelloWorld
{
    class Program 
    {
        // static void Main() 
        // {
        //     Console.WriteLine("Hello, World!");
        // }
        // static void Main (string[] args)
        // {
        //     Console.WriteLine("Hello, {0}!", args[0]);
        // }
         static void Main ()
        {
            Console.Write("Enter First Name: ");
            string fName=Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lName=Console.ReadLine();
            // Console.WriteLine("Hello, {1} {0}! ", fName,lName);
             Console.WriteLine($"Hello, {fName} {lName}!");// string interpolation
        }
    }
}