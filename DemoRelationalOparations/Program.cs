        int a = 25;
        int b = 20;

        Console.WriteLine("Relational Operators");

        Console.WriteLine("Equal: " + (a == b));
        Console.WriteLine("Not Equal: " + (a != b));
        Console.WriteLine("Greater Than: " + (a > b));
        Console.WriteLine("Less Than: " + (a < b));
        Console.WriteLine("Greater or Equal: " + (a >= b));
        Console.WriteLine("Less or Equal: " + (a <= b));

        // Practical Example: Student Result
        int marks = 75;
        int passingMarks = 40;

        if (marks >= passingMarks)
        {
            Console.WriteLine("Student Passed");
        }
        else
        {
            Console.WriteLine("Student Failed");
        }
 