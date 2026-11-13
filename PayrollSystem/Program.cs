
using System;
using System.Collections.Generic;

namespace PayrollSystem
{
    // Abstract Base Class
    abstract class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public decimal BasicSalary { get; set; }

        protected Employee(
            int employeeId,
            string name,
            decimal basicSalary)
        {
            EmployeeId = employeeId;
            Name = name;
            BasicSalary = basicSalary;
        }

        // Abstract Method
        public abstract decimal CalculateSalary();

        // Virtual Method
        public virtual void DisplayDetails()
        {
            Console.WriteLine("Employee ID: " + EmployeeId);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Basic Salary: " + BasicSalary);
        }
    }

    // Full-Time Employee
    class FullTimeEmployee : Employee
    {
        public decimal Allowance { get; set; }

        public FullTimeEmployee(
            int id,
            string name,
            decimal salary,
            decimal allowance)
            : base(id, name, salary)
        {
            Allowance = allowance;
        }

        public override decimal CalculateSalary()
        {
            return BasicSalary + Allowance;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();

            Console.WriteLine("Type: Full-Time");
            Console.WriteLine("Allowance: " + Allowance);
            Console.WriteLine("Total Salary: " + CalculateSalary());
        }
    }

    // Part-Time Employee
    class PartTimeEmployee : Employee
    {
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }

        public PartTimeEmployee(
            int id,
            string name,
            int hours,
            decimal rate)
            : base(id, name, 0m)
        {
            HoursWorked = hours;
            HourlyRate = rate;
        }

        public override decimal CalculateSalary()
        {
            return HoursWorked * HourlyRate;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();

            Console.WriteLine("Type: Part-Time");
            Console.WriteLine("Hours Worked: " + HoursWorked);
            Console.WriteLine("Hourly Rate: " + HourlyRate);
            Console.WriteLine("Total Salary: " + CalculateSalary());
        }
    }

    // Sealed Contract Employee
    sealed class ContractEmployee : Employee
    {
        public ContractEmployee(
            int id,
            string name,
            decimal fixedSalary)
            : base(id, name, fixedSalary)
        {
        }

        public override decimal CalculateSalary()
        {
            return BasicSalary;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();

            Console.WriteLine("Type: Contract");
            Console.WriteLine("Total Salary: " + CalculateSalary());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new FullTimeEmployee(101, "Amit", 50000m, 10000m),
                new PartTimeEmployee(102, "Priya", 80, 500m),
                new ContractEmployee(103, "Rahul", 45000m)
            };

            decimal totalPayroll = 0m;

            Console.WriteLine("EMPLOYEE PAYROLL SYSTEM");
            Console.WriteLine("=======================");

            foreach (Employee emp in employees)
            {
                emp.DisplayDetails();

                totalPayroll += emp.CalculateSalary();

                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("Total Payroll: " + totalPayroll);
        }
    }
}
 