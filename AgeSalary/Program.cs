using System;

class AgeSalary
{
    static void Main()
    {
        string ageText = "25";
        string salaryText = "45000";

        int age = Convert.ToInt32(ageText);
        double salary = Convert.ToDouble(salaryText);

        Console.WriteLine("Age: " + age);
        Console.WriteLine("Salary: " + salary);

        double number = 12.6;

        int converted = Convert.ToInt32(number);

        Console.WriteLine("Converted Number: " + converted);
    }
}