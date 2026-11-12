
using System;

class Product
{
    // Auto-implemented properties
    public int ProductId { get; init; }

    public string ProductName { get; set; } = "";

    public decimal Price { get; set; }

    // Private setter
    public int StockQuantity { get; private set; }

    // Property with default value
    public string Category { get; set; } = "General";

    // Constructor
    public Product(int stockQuantity)
    {
        if (stockQuantity < 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(stockQuantity));
        }

        StockQuantity = stockQuantity;
    }

    // Method to update stock
    public void AddStock(int quantity)
    {
        if (quantity > 0)
        {
            StockQuantity += quantity;
        }
    }

    // Method to display product
    public void DisplayProduct()
    {
        Console.WriteLine("Product ID: " + ProductId);
        Console.WriteLine("Product Name: " + ProductName);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Stock: " + StockQuantity);
        Console.WriteLine("Category: " + Category);
    }
}

class Program
{
    static void Main()
    {
        Product product = new Product(20)
        {
            ProductId = 101,
            ProductName = "Laptop",
            Price = 55000,
            Category = "Electronics"
        };

        Console.WriteLine("Initial Product Details:");
        product.DisplayProduct();

        product.AddStock(10);

        Console.WriteLine("\nAfter Stock Update:");
        product.DisplayProduct();
    }
}
 