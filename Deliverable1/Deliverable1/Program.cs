using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        int loop = 1;

        const int JellyJar = 48;
        const int PBJar = 32;
        const int Loaf = 28;

        const int SandwichSlices = 2;
        const int SandwichPB = 2;
        const int SandwichJelly = 4;

        while (loop == 1)
        {
            Console.WriteLine("How many people are we making PB&J sandwiches for?");
            int People = int.Parse(Console.ReadLine());

            int TotalSlices = People * SandwichSlices;
            int TotalPB = People * SandwichPB;
            int TotalJelly = People * SandwichJelly;

            double TotalLoaves = Math.Ceiling((double)Loaf / TotalSlices);
            double TotalPBJar = Math.Ceiling((double)PBJar / TotalPB);
            double TotalJellyJars = Math.Ceiling((double)JellyJar / TotalJelly);

            Console.Clear();

            Console.WriteLine("For " + People + " people, you will need: \n");
            Console.WriteLine(TotalSlices + " slices of bread,");
            Console.WriteLine(TotalPB + " tablespoons of peanut butter,");
            Console.WriteLine("and " + TotalJelly + " tablespoons of jelly.\n");

            Console.WriteLine("Which is: \n");
            Console.WriteLine($"{TotalLoaves} loaves of bread,");
            Console.WriteLine($"{TotalPBJar} jars of peanut butter,");
            Console.WriteLine($"and {TotalJellyJars} jars of jelly.\n");

            Console.WriteLine("Would you like to start over?");
            Console.WriteLine("To restart, press 'y' or enter 'yes'.");
            Console.WriteLine("To exit, press any key.");
            string restart = Console.ReadLine();
            if (restart == "Yes" || restart == "YES" || restart == "yes" || restart == "Y" || restart == "y")
            {
                Console.Clear();
            }
            else
            {
                loop = 0;
                Console.Clear();
                Console.WriteLine("Goodbye!");
            }
        }
    }
}  