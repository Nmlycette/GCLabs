using System;

namespace Deliverable2
{
    class Program
    {
        private static void Main(string[] args)
        {
            const decimal BuffetPrice = 9.99M;
            const decimal CoffeePrice = 2.00M;
            const decimal JuicePrice = 3.00M;

            int CoffeeCount = 0;
            int JuiceCount = 0;

            Console.WriteLine("Welcome to our all-day breakfast buffet! Our all-you-can-eat buffet is $9.99.");
            Console.WriteLine("Our drink options are coffee for $2.00 or juice for $3.00, with free refills.");
            Console.WriteLine("We are only seating parties no larger than six.");
            Console.WriteLine("\nHow many people are you in your party?");

            int PartyCount = int.Parse(Console.ReadLine());
            if (PartyCount <= 6)

            {
                Console.Clear();
                Console.Write($"Party of {PartyCount}! Please follow me to your table.");
                Console.WriteLine("Before you head over to our buffet, I will take your drink order.");
                Console.WriteLine("Again, our drink options are coffee for $2.00 or juice for $3.00, refills are free for both.");

                for (int i = 1; i <= PartyCount; i++)
                {
                    Console.WriteLine($"\nWhat will guest {i} have to drink, coffee or juice?");
                    string DrinkOrder = Console.ReadLine();
                    if (DrinkOrder == "Coffee" || DrinkOrder == "coffee" || DrinkOrder == "COFFEE")
                    {
                        CoffeeCount++;
                        Console.WriteLine("\nCoffee, got it.");
                    }
                    else if (DrinkOrder == "Juice" || DrinkOrder == "juice" || DrinkOrder == "JUICE")
                    {
                        JuiceCount++;
                        Console.WriteLine("\nJuice, got it.");
                    }
                    else
                    {
                        Console.WriteLine($"\nSorry, we don't have {DrinkOrder}. We only have coffee or juice.\n");
                    }
                }
                decimal BuffetTotal = BuffetPrice * PartyCount;
                decimal CoffeeTotal = CoffeePrice * CoffeeCount;
                decimal JuiceTotal = JuicePrice * JuiceCount;
                decimal TotalDue = BuffetTotal + CoffeeTotal + JuiceTotal;

                Console.Clear();
                Console.WriteLine($"Alright, that's {CoffeeCount} coffees and {JuiceCount} juices coming right up! Please feel free to visit the buffet.\n");
                Console.WriteLine("The total for your visit today comes to:\n");

                Console.WriteLine($"{PartyCount} Breakfast Buffett x ${BuffetPrice} = ${BuffetTotal}");
                Console.WriteLine($"{CoffeeCount} Coffee x ${CoffeePrice} = ${CoffeeTotal}");
                Console.WriteLine($"{JuiceCount} Juice x ${JuicePrice} = ${JuiceTotal}");
                Console.WriteLine($"Total = ${TotalDue}\n");
                Console.WriteLine("Thank you, we hope to see you again soon!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Sorry, we can't seat parties greater than six right now.");
            }
        }
    }
}