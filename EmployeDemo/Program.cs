
using System;

class Employee
{
    public string Name;
    public double BasicSalary;

    // Constructor
    public Employee(string name, double salary)
    {
        Name = name;
        BasicSalary = salary;
    }

    // Instance method without return value
    public void DisplayEmployee()
    {
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Basic Salary: " + BasicSalary);
    }

    // Method with return value
    public double CalculateAnnualSalary()
    {
        return BasicSalary * 12;
    }

    // Method with parameters
    public double CalculateBonus(double percentage)
    {
        return BasicSalary * percentage / 100;
    }

    // Method overloading - one parameter
    public double CalculateTax(double salary)
    {
        return salary * 0.10;
    }

    // Method overloading - two parameters
    public double CalculateTax(double salary, double taxRate)
    {
        return salary * taxRate / 100;
    }

    // Static method
    public static void CompanyInformation()
    {
        Console.WriteLine("Company: ABC Technologies");
    }
}

class Program
{
    static void Main()
    {
        // Calling static method
        Employee.CompanyInformation();

        // Creating object
        Employee emp = new Employee("Amit", 50000);

        // Calling instance method
        emp.DisplayEmployee();

        // Calling method with return value
        double annualSalary = emp.CalculateAnnualSalary();
        Console.WriteLine("Annual Salary: " + annualSalary);

        // Calling method with parameter
        double bonus = emp.CalculateBonus(15);
        Console.WriteLine("Bonus: " + bonus);

        // Method overloading
        Console.WriteLine("Default Tax: " +
            emp.CalculateTax(50000));

        Console.WriteLine("Custom Tax: " +
            emp.CalculateTax(50000, 20));
    }
}
 