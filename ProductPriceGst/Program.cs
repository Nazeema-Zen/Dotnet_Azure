using System;

class ProductPriceGst
{
    static void Main()
    {
        decimal productPrice = 1999.99m;
        int quantity = 3;

        decimal subtotal = productPrice * quantity;
        decimal gst = subtotal * 0.18m;
        decimal total = subtotal + gst;

        Console.WriteLine("Product Price: " + productPrice);
        Console.WriteLine("Quantity: " + quantity);
        Console.WriteLine("Subtotal: " + subtotal);
        Console.WriteLine("GST: " + gst);
        Console.WriteLine("Total: " + total);
    }
}