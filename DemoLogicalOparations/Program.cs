        int age = 25;
        bool hasLicense = true;
        bool hasPassport = false;

        Console.WriteLine("Logical Operators");

        // Logical AND
        if (age >= 18 && hasLicense)
        {
            Console.WriteLine("Eligible to Drive");
        }
        else
        {
            Console.WriteLine("Not Eligible to Drive");
        }

        // Logical OR
        if (hasLicense || hasPassport)
        {
            Console.WriteLine("At least one ID is available");
        }

        // Logical NOT
        if (!hasPassport)
        {
            Console.WriteLine("Passport is not available");
        }

        // Logical XOR
        bool a = true;
        bool b = false;

        Console.WriteLine("XOR Result: " + (a ^ b));