bool userShopping = true;
decimal total = 0;
int appleCount = 0;
int orangeCount = 0;
int milkCount = 0;
int sandwichCount = 0;
int breadCount = 0;
int juiceCount = 0;
int saladCount = 0;
int chipsCount = 0;

List<string> shopperList = new List<string>();

Dictionary<string, decimal> menuItems = new Dictionary<string, decimal>()
{
    { "Apple", 1.00m },
    { "Orange" , 1.00m },
    { "Milk", 2.50m },
    { "Sandwich", 3.50m },
    { "Bread", 1.50m },
    { "Juice", 2.50m },
    { "Salad", 3.00m },
    { "Chips", 2.00m},
};

void AddShopperItems()
{
    do
    {
        Console.WriteLine("\nWhat item(s) would you like to purchase? Enter 'done' to checkout.");
        string itemInput = Console.ReadLine();
        itemInput = char.ToUpper(itemInput[0]) + itemInput.Substring(1); //capitalizing first letter of user input. takes everything , past 1 and leaves it as such, then re

        if (itemInput ==  "Done")
        {
            userShopping = false;
            int shopperListCount = shopperList.Count;
            ShopperCheckout(itemInput, total, shopperListCount);
            break;
        }
        else
        {
            ValidGroceryItemChecker(itemInput);

            var filter = menuItems
            .Where(X => X.Key.Contains(itemInput));

            foreach (var item in filter)
            {
                string item1 = item.Key;
                decimal price = item.Value;
                total = total + price;

                if (item.Key == "Apple")
                {
                    appleCount++;
                }

                if (item.Key == "Orange")
                {
                    orangeCount++;
                }

                if (item.Key == "Milk")
                {
                    milkCount++;
                }

                if (item.Key == "Sandwich")
                {
                    sandwichCount++;
                }

                if (item.Key == "Bread")
                {
                    breadCount++;
                }

                if (item.Key == "Juice")
                {
                    juiceCount++;
                }

                if (item.Key == "Salad")
                {
                    saladCount++;
                }

                if (item.Key == "Chips")
                {
                    chipsCount++;
                }
                Console.WriteLine($"Current total: ${total}");
            }
        }
    } while (userShopping == true);

}

string ValidGroceryItemChecker(string itemInput)
{
    itemInput = char.ToUpper(itemInput[0]) + itemInput.Substring(1); //capitalizing first letter of user input. takes everything , past 1 and leaves it as such, then re-combines it into a single string

    if (menuItems.ContainsKey(itemInput))
    {
        shopperList.Add(itemInput);
        return itemInput;
    }
    else
    {
        Console.WriteLine("Invalid option. Please enter an item from the menu.");
    }
    return itemInput;
}

void ShopperCheckout(string itemInput, decimal total, int shopperListCount)
{
    Console.Clear();
    
    Console.WriteLine("\nYour cart:");
    if (appleCount > 0)
    {
        decimal totalAppleCost = appleCount * 1.00m;
        Console.WriteLine($"{appleCount} x Apple = ${totalAppleCost}");
    }
    if (orangeCount > 0)
    {
        decimal totalOrangeCost = orangeCount * 1.00m;
        Console.WriteLine($"{orangeCount} x Orange = ${totalOrangeCost}");
    }
    if (milkCount > 0)
    {
        decimal totalMilkCost = milkCount * 2.50m;
        Console.WriteLine($"{milkCount} x Milk = ${totalMilkCost}");
    }
    if (sandwichCount > 0)
    {
        decimal totalSandwichCost = sandwichCount * 3.50m;
        Console.WriteLine($"{sandwichCount} x Sandwich = ${totalSandwichCost}");
    }
    if (breadCount > 0)
    {
        decimal totalBreadCost = breadCount * 1.50m;
        Console.WriteLine($"{breadCount} x Bread = ${totalBreadCost}");
    }
    if (juiceCount > 0)
    {
        decimal totalJuiceCost = juiceCount * 2.50m;
        Console.WriteLine($"{juiceCount} x Juice= ${totalJuiceCost}");
    }
    if (saladCount > 0)
    {
        decimal totalSaladCost = saladCount * 3.00m;
        Console.WriteLine($"{saladCount} x Salad = ${totalSaladCost}");
    }
    if (chipsCount > 0)
    {
        decimal totalChipsCost = chipsCount * 2.00m;
        Console.WriteLine($"{chipsCount} x Chips = ${totalChipsCost}");
    }

    Console.Write($"Total Cost: ${total}");
    Console.WriteLine("\nAverage Price: $" + total/shopperListCount);
}

Console.WriteLine("Welcome to the marketplace! Here are our items:");
Console.WriteLine("-------------------");
foreach (KeyValuePair<string, decimal> menuItem in menuItems)
{
    Console.WriteLine($"{menuItem.Key} - ${menuItem.Value}");
}
Console.WriteLine("-------------------");

AddShopperItems();