using System;

class Program
{
    static void Main()
    {
        // Console.Write("Enter student marks: ");

        // int marks = Convert.ToInt32(Console.ReadLine());

        // if (marks < 0 || marks > 100)
        // {
        //     Console.WriteLine("Invalid Marks");
        // }
        // else if (marks >= 90)
        // {
        //     Console.WriteLine("Grade A+");
        // }
        // else if (marks >= 75)
        // {
        //     Console.WriteLine("Grade A");
        // }
        // else if (marks >= 60)
        // {
        //     Console.WriteLine("Grade B");
        // }
        // else if (marks >= 40)
        // {
        //     Console.WriteLine("Grade C");
        // }
        // else
        // {
        //     Console.WriteLine("Fail");
        // }
        // Loan

        Console.Write("Enter employee salary: ");
        decimal salary = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter years of experience: ");
        int experience = Convert.ToInt32(Console.ReadLine());

        if (salary >= 30000)
        {
            if (experience >= 3)
            {
                Console.WriteLine("Loan Approved");
            }
            else
            {
                Console.WriteLine(
                    "Loan Rejected: Insufficient Experience"
                );
            }
        }
        else
        {
            Console.WriteLine(
                "Loan Rejected: Insufficient Salary"
            );
        }
    }
}