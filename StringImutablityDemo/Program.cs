// using System;

// class Program
// {
//     static void Main()
//     {
//         string name1 = "Amit";

//         string name2 = name1;

//         name2 = "Rahul";

//         Console.WriteLine("Name1: " + name1);
//         Console.WriteLine("Name2: " + name2);
//     }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         var employeeId = 101;

//         var employeeName = "Amit";

//         var salary = 55000.50m;

//         var isActive = true;

//         var rating = 4.5;

//         Console.WriteLine("Employee Details");
//         Console.WriteLine("----------------");

//         Console.WriteLine($"ID: {employeeId}");
//         Console.WriteLine($"Name: {employeeName}");
//         Console.WriteLine($"Salary: {salary}");
//         Console.WriteLine($"Active: {isActive}");
//         Console.WriteLine($"Rating: {rating}");

//         Console.WriteLine("\nInferred Types:");

//         Console.WriteLine(employeeId.GetType());
//         Console.WriteLine(employeeName.GetType());
//         Console.WriteLine(salary.GetType());
//         Console.WriteLine(isActive.GetType());
//         Console.WriteLine(rating.GetType());
//     }
// }

using System;

class Program
{
    static void Main()
    {
        var employeeId = 101;

        var employeeName = "Amit";

        var salary = 55000.50m;

        var isActive = true;

        var rating = 4.5;

        Console.WriteLine("Employee Details");
        Console.WriteLine("----------------");

        Console.WriteLine($"ID: {employeeId}");
        Console.WriteLine($"Name: {employeeName}");
        Console.WriteLine($"Salary: {salary}");
        Console.WriteLine($"Active: {isActive}");
        Console.WriteLine($"Rating: {rating}");

        Console.WriteLine("\nInferred Types:");

        Console.WriteLine(employeeId.GetType());
        Console.WriteLine(employeeName.GetType());
        Console.WriteLine(salary.GetType());
        Console.WriteLine(isActive.GetType());
        Console.WriteLine(rating.GetType());
    }
}