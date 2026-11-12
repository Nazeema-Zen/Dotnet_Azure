using System;

namespace CustomTypesDemo
{
    // Enumeration
    enum Department
    {
        HR,
        IT,
        Finance,
        Sales
    }

    // Structure
    struct Address
    {
        public string City;
        public string State;
    }

    // Class
    class Employee
    {
        public int Id;
        public string Name = "";
        public Department Department;
        public Address Address;

        public void Display()
        {
            Console.WriteLine($"Employee ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"City: {Address.City}");
            Console.WriteLine($"State: {Address.State}");
        }
    }

    class Program
    {
        static void Main()
        {
            Employee emp = new Employee();

            emp.Id = 101;
            emp.Name = "Amit";
            emp.Department = Department.IT;

            emp.Address = new Address
            {
                City = "Pune",
                State = "Maharashtra"
            };

            emp.Display();
        }
    }
}