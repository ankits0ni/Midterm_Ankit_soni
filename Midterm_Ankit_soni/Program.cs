using System;

public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; } 

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of item
    public void UpdatePrice(double newPrice)
    {
        Price = newPrice;
        Console.WriteLine($"Price updated for {ItemName} (ID: {ItemId}): ${Price}");
    }

    // Restocking the item
    public void RestockItem(int additionalQuantity)
    {
        QuantityInStock += additionalQuantity;
        Console.WriteLine($"{additionalQuantity} units of {ItemName} (ID: {ItemId}) restocked. New stock quantity: {QuantityInStock}");
    }

    // Sell of item
    public void SellItem(int quantitySold)
    {
        if (QuantityInStock >= quantitySold)
        {
            QuantityInStock -= quantitySold;
            Console.WriteLine($"{quantitySold} units of {ItemName} (ID: {ItemId}) sold.");
        }
        else
        {
            Console.WriteLine($"Insufficient stock for {ItemName} (ID: {ItemId}). Unable to sell.");
        }
    }

    // Check if item is in stock or not
    public bool IsInStock()
    {
        return QuantityInStock > 0;
    }

    // Print item details
    public void PrintDetails()
    {
        Console.WriteLine($"Item: {ItemName} (ID: {ItemId})");
        Console.WriteLine($"Price: ${Price}");
        Console.WriteLine($"Quantity in Stock: {QuantityInStock}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        
        //Display details of all items.
        Console.WriteLine("Item Details:");
        item1.PrintDetails();
        item2.PrintDetails();

        //Sell some items and Display the updated details.
        item1.SellItem(2);
        item2.SellItem(5);
        Console.WriteLine("\nItem Details after selling:");
        item1.PrintDetails();
        item2.PrintDetails();

        //Restock an item and Display the updated details.
        item1.RestockItem(5);
        Console.WriteLine("\nItem Details after restocking:");
        item1.PrintDetails();

        //Check if an item is in stock and Display message accordingly.
        Console.WriteLine($"\nIs {item2.ItemName} in stock? {item2.IsInStock()}");
    }
}
