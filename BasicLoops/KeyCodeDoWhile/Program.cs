//DoWhile Key Code
void DoWhileKeyCode()
{
    bool check = true;

    string door = "locked";
    const int CODE = 13579;
    int numberofAttempts = 5;
    int userGuess = 0;

    do
    {
        if (numberofAttempts > 0)
        {
            Console.WriteLine("Enter your keycode.");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess == CODE)
            {
                door = "unlocked";
                Console.WriteLine("Welcome!");
            }
            else if (userGuess != CODE && numberofAttempts > 0)
            {
                numberofAttempts--;
                Console.WriteLine($"Incorrect keycode entered. You have {numberofAttempts} remaining attempts.");
            }
        }
        else //number of attempts used up
        {
            Console.WriteLine("Too many incorrect attempts. Try again later.");
            break;
        }
    } while (door == "locked");
}

//Stretch Key Code
void StretchDoWhileKeyCode()
{
    bool check = true;

    bool doorUnlock = false;
    const int CODE = 13579;
    int numberofAttempts = 5;
    int userGuess = 0;

    do
    {
        if (numberofAttempts > 0)
        {
            Console.WriteLine("Enter your keycode.");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess == CODE)
            {
                doorUnlock = true;
                Console.WriteLine("Welcome!");
                bool accessMethodChecker = AccessGranted(doorUnlock);
                Console.WriteLine($"Access granted: {accessMethodChecker}");
            }
            else if (userGuess != CODE && numberofAttempts > 0)
            {
                numberofAttempts--;
                Console.WriteLine($"Incorrect keycode entered. You have {numberofAttempts} remaining attempts.");
            }
        }
        else //number of attempts used up
        {
            Console.WriteLine("Too many incorrect attempts. Try again later.");
            bool accessMethodChecker = AccessGranted(doorUnlock);
            Console.WriteLine($"Access granted: {accessMethodChecker}");
            break;
        }
    } while (doorUnlock == false);
}

//Return method for Stretch
bool AccessGranted(bool doorUnlock)
{
        return doorUnlock;
}
