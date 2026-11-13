
using System;

namespace SealedMethodDemo
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

        public virtual double CalculateBonus()
        {
            return Salary * 0.10;
        }

        public virtual void DisplayRole()
        {
            Console.WriteLine("Role: Employee");
        }
    }

    // Derived Class
    class Manager : Employee
    {
        public Manager(string name, double salary)
            : base(name, salary)
        {
        }

        // Sealed Override
        public sealed override double CalculateBonus()
        {
            return Salary * 0.20;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("Role: Manager");
        }
    }

    // Further Derived Class
    class SeniorManager : Manager
    {
        public SeniorManager(string name, double salary)
            : base(name, salary)
        {
        }

        // Allowed: DisplayRole is not sealed
        public override void DisplayRole()
        {
            Console.WriteLine("Role: Senior Manager");
        }

        // Not allowed:
        // CalculateBonus is sealed in Manager

        // public override double CalculateBonus()
        // {
        //     return Salary * 0.30;
        // }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp =
                new SeniorManager("Amit", 100000);

            Console.WriteLine("Name: " + emp.Name);
            emp.DisplayRole();

            Console.WriteLine("Salary: " + emp.Salary);
            Console.WriteLine("Bonus: " + emp.CalculateBonus());
        }
    }
}
 