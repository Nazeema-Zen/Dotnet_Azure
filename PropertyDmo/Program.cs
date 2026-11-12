
using System;

class Employee
{
    private int employeeId;
    private string name = "";
    private decimal salary;

    // Read-only property
    public int EmployeeId
    {
        get
        {
            return employeeId;
        }
    }

    // Read-write property
    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                name = value;
            }
            else
            {
                Console.WriteLine("Invalid Employee Name");
            }
        }
    }

    // Property with validation
    public decimal Salary
    {
        get
        {
            return salary;
        }

        set
        {
            if (value >= 0)
            {
                salary = value;
            }
            else
            {
                Console.WriteLine("Salary cannot be negative");
            }
        }
    }

    // Computed property
    public decimal AnnualSalary
    {
        get
        {
            return salary * 12;
        }
    }

    public Employee(int id, string name, decimal salary)
    {
        employeeId = id;
        Name = name;
        Salary = salary;
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee(101, "Amit", 50000);

        Console.WriteLine("Employee ID: " + emp.EmployeeId);
        Console.WriteLine("Employee Name: " + emp.Name);
        Console.WriteLine("Monthly Salary: " + emp.Salary);
        Console.WriteLine("Annual Salary: " + emp.AnnualSalary);

        // Updating property
        emp.Salary = 60000;

        Console.WriteLine("Updated Salary: " + emp.Salary);

        // Invalid salary
        emp.Salary = -5000;

        Console.WriteLine("Final Salary: " + emp.Salary);
    }
}
 