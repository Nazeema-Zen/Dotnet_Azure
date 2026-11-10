Console.Write("Enter First Number: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter Second Number: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Enter the operator <+, -, *, /, %>: ");
char op = char.Parse(Console.ReadLine());
float result = 0;
switch (op)
{
    case '+':
        result = a + b;
        break;
    case '-':
        result = a - b;
        break;
    case '*':
        result = a * b;
        break;
    case '/':
        result = (float) a / b;
        break;
    case '%':
        result = a % b;
        break;
    default:
        Console.WriteLine("Invalid operator entered.");
        break;
}
Console.WriteLine($"{a} {op} {b} = {result}");