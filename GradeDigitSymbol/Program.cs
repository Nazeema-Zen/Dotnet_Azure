using System;

class GradeDigitSymbol
{
    static void Main()
    {
        char grade = 'A';
        char digit = '5';
        char symbol = '@';

        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Digit: " + digit);
        Console.WriteLine("Symbol: " + symbol);

        Console.WriteLine("\nCharacter Checks");

        Console.WriteLine(char.IsLetter(grade));
        Console.WriteLine(char.IsDigit(digit));
        Console.WriteLine(char.IsSymbol(symbol));
        Console.WriteLine(char.IsPunctuation(symbol));

        Console.WriteLine("\nConversions");

        Console.WriteLine(char.ToLower(grade));
        Console.WriteLine(char.ToUpper('b'));
    }
}