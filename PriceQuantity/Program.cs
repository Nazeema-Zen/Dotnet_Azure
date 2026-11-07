using System;

class PriceQuantity
{
    static void Main()
    {
        double price = 125.75;
        double quantity = 3;

        double total = price * quantity;
        double discount = total * 0.10;
        double finalAmount = total - discount;

        Console.WriteLine("Total: " + total);
        Console.WriteLine("Discount: " + discount);
        Console.WriteLine("Final Amount: " + finalAmount);
    }
}