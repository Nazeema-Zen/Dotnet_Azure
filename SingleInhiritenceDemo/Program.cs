using System;

namespace SingleInheritanceDemo
{
    // Base Class
    class Employee
    {
        public int EmployeeId;
        public string Name;
        public double Salary;

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee ID: " + EmployeeId);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Salary: " + Salary);
        }

        public double CalculateBonus()
        {
            return Salary * 0.10;
        }
    }

    // Derived Class
    class Manager : Employee
    {
        public string Department;

        public void DisplayManagerDetails()
        {
            DisplayEmployeeDetails();

            Console.WriteLine("Department: " + Department);
            Console.WriteLine("Bonus: " + CalculateBonus());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();

            manager.EmployeeId = 101;
            manager.Name = "Amit";
            manager.Salary = 80000;
            manager.Department = "IT";

            Console.WriteLine("Manager Details");
            Console.WriteLine("--------------------");

            manager.DisplayManagerDetails();
        }
    }
}