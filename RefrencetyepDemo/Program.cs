// using System;

// class Employee
// {
//     public string Name = "";
//     public decimal Salary;
// }

// class Program
// {
//     static void Main()
//     {
//         Employee emp1 = new Employee();

//         emp1.Name = "Amit";
//         emp1.Salary = 50000;

//         Employee emp2 = emp1;

//         Console.WriteLine("Before Modification:");

//         Console.WriteLine($"Emp1: {emp1.Name}, {emp1.Salary}");
//         Console.WriteLine($"Emp2: {emp2.Name}, {emp2.Salary}");

//         emp2.Name = "Rahul";
//         emp2.Salary = 70000;

//         Console.WriteLine("\nAfter Modification:");

//         Console.WriteLine($"Emp1: {emp1.Name}, {emp1.Salary}");
//         Console.WriteLine($"Emp2: {emp2.Name}, {emp2.Salary}");
//     }
// }

// using System;

// class Employee
// {
//     public string Name = "";
//     public decimal Salary;
// }

// class Program
// {
//     static void IncreaseSalary(Employee employee)
//     {
//         employee.Salary += 10000;
//     }

//     static void Main()
//     {
//         Employee emp = new Employee
//         {
//             Name = "Amit",
//             Salary = 50000
//         };

//         Console.WriteLine("Before Increment: " + emp.Salary);

//         IncreaseSalary(emp);

//         Console.WriteLine("After Increment: " + emp.Salary);
//     }
// }


using System;

class Employee
{
    public string Name = "";
    public decimal Salary;
}

class Program
{
    static void IncreaseSalary(Employee employee)
    {
        employee.Salary += 10000;
    }

    static void Main()
    {
        Employee emp = new Employee
        {
            Name = "Amit",
            Salary = 50000
        };

        Console.WriteLine("Before Increment: " + emp.Salary);

        IncreaseSalary(emp);

        Console.WriteLine("After Increment: " + emp.Salary);
    }
}