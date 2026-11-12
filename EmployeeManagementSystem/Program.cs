using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagementSystem
{
    // Enum: Value Type
    enum Department
    {
        HR,
        IT,
        Finance,
        Sales
    }

    // Struct: Value Type
    struct Address
    {
        public string City;
        public string State;

        public void Display()
        {
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"State: {State}");
        }
    }

    // Class: Reference Type
    class Employee
    {
        public int Id;
        public string Name = "";
        public decimal Salary;
        public Department Department;
        public Address Address;

        public void Display()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Employee ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Department: {Department}");

            Address.Display();
        }

        public void IncreaseSalary(decimal percentage)
        {
            Salary += Salary * percentage / 100;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("EMPLOYEE MANAGEMENT SYSTEM");
            Console.WriteLine("==========================");

            // Create employee objects
            Employee emp1 = new Employee
            {
                Id = 101,
                Name = "Amit",
                Salary = 50000,
                Department = Department.IT,

                Address = new Address
                {
                    City = "Pune",
                    State = "Maharashtra"
                }
            };

            Employee emp2 = new Employee
            {
                Id = 102,
                Name = "Rahul",
                Salary = 60000,
                Department = Department.HR,

                Address = new Address
                {
                    City = "Mumbai",
                    State = "Maharashtra"
                }
            };

            // Generic collection
            var employees = new List<Employee>
            {
                emp1,
                emp2
            };

            Console.WriteLine("\n1. Employee Records");

            foreach (var employee in employees)
            {
                employee.Display();
            }

            // Value type demonstration
            Console.WriteLine("\n2. Value Type Demonstration");

            int salary1 = 50000;

            int salary2 = salary1;

            salary2 = 70000;

            Console.WriteLine($"Salary1: {salary1}");
            Console.WriteLine($"Salary2: {salary2}");

            // Reference type demonstration
            Console.WriteLine("\n3. Reference Type Demonstration");

            Employee emp3 = emp1;

            emp3.Name = "Amit Sharma";

            Console.WriteLine($"Emp1 Name: {emp1.Name}");
            Console.WriteLine($"Emp3 Name: {emp3.Name}");

            // Boxing and unboxing
            Console.WriteLine("\n4. Boxing and Unboxing");

            int bonus = 10000;

            object boxedBonus = bonus;

            int unboxedBonus = (int)boxedBonus;

            Console.WriteLine($"Original Bonus: {bonus}");
            Console.WriteLine($"Boxed Bonus: {boxedBonus}");
            Console.WriteLine($"Unboxed Bonus: {unboxedBonus}");

            // Salary increment
            Console.WriteLine("\n5. Salary Increment");

            emp1.IncreaseSalary(10);

            Console.WriteLine($"Updated Salary: {emp1.Salary}");

            // Implicit typing with LINQ
            Console.WriteLine("\n6. High Salary Employees");

            var highSalaryEmployees = employees
                .Where(e => e.Salary > 55000)
                .ToList();

            foreach (var employee in highSalaryEmployees)
            {
                Console.WriteLine(
                    $"{employee.Name} - {employee.Salary}"
                );
            }

            // Total salary
            var totalSalary = employees.Sum(e => e.Salary);

            Console.WriteLine($"\nTotal Salary: {totalSalary}");

            // Average salary
            var averageSalary = employees.Average(e => e.Salary);

            Console.WriteLine($"Average Salary: {averageSalary}");

            Console.WriteLine("\nProgram Completed Successfully");
        }
    }
}