using System.Diagnostics.CodeAnalysis;

void DoWhileHelloWorld()
{
    string replay = string.Empty;
    do
    {
        Console.WriteLine("Hello, world!");
        Console.WriteLine("Would you like to restart (y/n)?");
        replay = Console.ReadLine().ToLower().Trim();

        if (replay == "y")
        {
            Console.Clear();
        }
        else if (replay == "n")
        {
            Console.Clear();
            Console.WriteLine("Goodbye!");
        }

    } while (replay != "n");

    Console.ReadKey();
}


void NumberCounter()
{
    int loop = 1;
    while (loop == 1)
    {
        Console.WriteLine("Enter a number");
        int numberInput = int.Parse(Console.ReadLine());

        for (int i = 0; i <= numberInput; i++)
        {
            int countDownNumber = numberInput - i;
            Console.Write($"{countDownNumber} ");
        }
        Console.WriteLine("");

        for (int i = 0; i <= numberInput; i++)
        {
            Console.Write($"{i} ");
        }

        string replay = string.Empty;
        do
        {
            Console.WriteLine("\nWould you like to restart (y/n)?");
            replay = Console.ReadLine().ToLower().Trim();

            if (replay == "y")
            {
                Console.Clear();
                break;
            }
            else if (replay == "n")
            {
                loop = 0;
                Console.Clear();
                Console.WriteLine("Goodbye!");
            }

        } while (replay != "n");
    }
}


void KeyCode()
{
    bool check = true;

    string door = "locked";
    const int CODE = 13579;
    int numberofAttempts = 5;
    int userGuess = 0;

    while (door == "locked")
    {
        if (numberofAttempts > 0)
        {
            Console.WriteLine("Enter your keycode.");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess == CODE)
            {
                door = "unlocked";
                Console.WriteLine("Welcome!");
                break;
            }
            else if (userGuess != CODE && numberofAttempts > 0)
            {
                numberofAttempts--;
                Console.WriteLine($"Incorrect code entered. You have {numberofAttempts} remaining attempts.");
            }
        }
        else //number of attempts used up
        {
            Console.WriteLine("Too many incorrect attempts. Try again later.");
            break;
        }
    }
}