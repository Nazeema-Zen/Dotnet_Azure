
// using System;

// class BankingService
// {
//     // Pass by value
//     public void UpdateBalanceByValue(decimal balance)
//     {
//         balance += 1000;
//         Console.WriteLine("Inside Value Method: " + balance);
//     }

//     // Pass by reference
//     public void Deposit(ref decimal balance, decimal amount)
//     {
//         balance += amount;
//     }

//     // Output parameter
//     public bool Withdraw(
//         decimal balance,
//         decimal amount,
//         out decimal remainingBalance)
//     {
//         if (amount <= balance && amount > 0)
//         {
//             remainingBalance = balance - amount;
//             return true;
//         }

//         remainingBalance = balance;
//         return false;
//     }

//     // Read-only reference parameter
//     public void DisplayBalance(in decimal balance)
//     {
//         Console.WriteLine("Current Balance: " + balance);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         BankingService bank = new BankingService();

//         decimal balance = 10000;

//         Console.WriteLine("Initial Balance: " + balance);

//         // Pass by value
//         bank.UpdateBalanceByValue(balance);

//         Console.WriteLine("After Value Method: " + balance);

//         // Pass by reference
//         bank.Deposit(ref balance, 5000);

//         Console.WriteLine("After Deposit: " + balance);

//         // Output parameter
//         decimal remainingBalance;

//         bool success = bank.Withdraw(
//             balance,
//             3000,
//             out remainingBalance);

//         if (success)
//         {
//             balance = remainingBalance;
//             Console.WriteLine("Withdrawal Successful");
//         }
//         else
//         {
//             Console.WriteLine("Withdrawal Failed");
//         }

//         // Read-only reference
//         bank.DisplayBalance(in balance);
//     }
// }
 
 
using System;

class StudentResult
{
    // Method using params
    public int CalculateTotal(params int[] marks)
    {
        int total = 0;

        foreach (int mark in marks)
        {
            total += mark;
        }

        return total;
    }

    // Method with regular parameter and params
    public void DisplayResult(
        string studentName,
        params int[] marks)
    {
        int total = CalculateTotal(marks);

        if (marks.Length == 0)
        {
            Console.WriteLine(studentName + ": No marks available");
            return;
        }

        double average = (double)total / marks.Length;

        Console.WriteLine("Student: " + studentName);
        Console.WriteLine("Subjects: " + marks.Length);
        Console.WriteLine("Total Marks: " + total);
        Console.WriteLine("Average Marks: " + average);
        Console.WriteLine("-----------------------");
    }
}

class Program
{
    static void Main()
    {
        StudentResult result = new StudentResult();

        // Three arguments
        result.DisplayResult("Amit", 80, 85, 90);

        // Five arguments
        result.DisplayResult("Priya", 75, 80, 85, 90, 95);

        // Two arguments
        result.DisplayResult("Rahul", 70, 80);

        // No marks
        result.DisplayResult("Neha");
    }
}
 