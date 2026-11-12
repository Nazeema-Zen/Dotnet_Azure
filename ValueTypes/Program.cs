// using System;

// class Program
// {
//     static void Main()
//     {
//         int number1 = 100;

//         int number2 = number1;

//         Console.WriteLine("Before Modification:");
//         Console.WriteLine("Number1: " + number1);
//         Console.WriteLine("Number2: " + number2);

//         number2 = 500;

//         Console.WriteLine("\nAfter Modification:");
//         Console.WriteLine("Number1: " + number1);
//         Console.WriteLine("Number2: " + number2);
//     }
// }

// using System;

// struct Student
// {
//     public int RollNo;
//     public string Name;
//     public int Marks;

//     public void Display()
//     {
//         Console.WriteLine($"Roll No: {RollNo}");
//         Console.WriteLine($"Name: {Name}");
//         Console.WriteLine($"Marks: {Marks}");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Student student1 = new Student
//         {
//             RollNo = 101,
//             Name = "Rahul",
//             Marks = 85
//         };

//         Student student2 = student1;

//         student2.Name = "Amit";
//         student2.Marks = 95;

//         Console.WriteLine("Student 1:");
//         student1.Display();

//         Console.WriteLine("\nStudent 2:");
//         student2.Display();
//     }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         int number1 = 100;

//         int number2 = number1;

//         Console.WriteLine("Before Modification:");
//         Console.WriteLine("Number1: " + number1);
//         Console.WriteLine("Number2: " + number2);

//         number2 = 500;

//         Console.WriteLine("\nAfter Modification:");
//         Console.WriteLine("Number1: " + number1);
//         Console.WriteLine("Number2: " + number2);
//     }
// }
using System;

class Program
{
    static void ChangeValue(ref int number)
    {
        number = 999;
    }

    static void Main()
    {
        int value = 100;

        Console.WriteLine("Before Method: " + value);

        ChangeValue(ref value);

        Console.WriteLine("After Method: " + value);
    }
}