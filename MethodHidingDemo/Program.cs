using System;

namespace MethodHidingDemo
{
    class Employee
    {
        public void DisplayDetails()
        {
            Console.WriteLine(
                "Displaying Employee Details"
            );
        }
    }

    class Manager : Employee
    {
        public new void DisplayDetails()
        {
            Console.WriteLine(
                "Displaying Manager Details"
            );
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Employee object
            Employee employee = new Employee();

            employee.DisplayDetails();

            // Manager object
            Manager manager = new Manager();

            manager.DisplayDetails();

            // Base class reference to Manager object
            Employee empRef = new Manager();

            empRef.DisplayDetails();
        }
    }
}