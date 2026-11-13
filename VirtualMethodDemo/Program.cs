
using System;

namespace VirtualMethodDemo
{
    // Base Class
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        // Virtual Method
        public virtual double CalculateBonus()
        {
            return Salary * 0.10;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Bonus: " + CalculateBonus());
        }
    }

    // Derived Class - Manager
    class Manager : Employee
    {
        public Manager(string name, double salary)
            : base(name, salary)
        {
        }

        public override double CalculateBonus()
        {
            return Salary * 0.20;
        }
    }

    // Derived Class - Developer
    class Developer : Employee
    {
        public Developer(string name, double salary)
            : base(name, salary)
        {
        }

        public override double CalculateBonus()
        {
            return Salary * 0.15;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Amit", 30000);
            Employee emp2 = new Manager("Rahul", 80000);
            Employee emp3 = new Developer("Priya", 60000);

            Employee[] employees = { emp1, emp2, emp3 };

            foreach (Employee emp in employees)
            {
                emp.DisplayDetails();
                Console.WriteLine("-------------------");
            }
        }
    }
}
 