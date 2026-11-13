using System;

namespace AccessControlDemo
{
    class Employee
    {
        public string Name = "Amit";

        private double Salary = 80000;

        protected string Department = "IT";

        internal string Company = "ABC Technologies";

        protected internal int EmployeeId = 101;

        private protected double BonusPercentage = 0.20;

        public void DisplaySalary()
        {
            Console.WriteLine("Salary: " + Salary);
        }
    }

    class Manager : Employee
    {
        public void DisplayDetails()
        {
            // Public member
            Console.WriteLine("Name: " + Name);

            // Protected member
            Console.WriteLine("Department: " + Department);

            // Internal member
            Console.WriteLine("Company: " + Company);

            // Protected Internal member
            Console.WriteLine("Employee ID: " + EmployeeId);

            // Private Protected member
            Console.WriteLine(
                "Bonus Percentage: " + BonusPercentage
            );

            // Private member cannot be accessed directly
            // Console.WriteLine(Salary); // Compilation error

            // Access private salary through public method
            DisplaySalary();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();

            manager.DisplayDetails();
        }
    }
}