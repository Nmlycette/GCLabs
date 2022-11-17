string[] nameArray = { "Megan", "Tom", "Lexi", "Gary" };
string[] hometownArray = { "Atlanta", "Southfield", "St. Clair Shores", "Detroit" };
string[] faveFoodArray = { "Pizza", "Tacos", "Hamburger", "Prime Rib" };
int studentTotal = nameArray.Length;
string hometownString = "Hometown";
string faveFoodString = "Favorite Food";


void StudentDeets (string[] nameArray)
{
    do 
    {
        Console.WriteLine($"Please select a student number (1 - {studentTotal})");
        int numberInput = int.Parse(Console.ReadLine());


        if (numberInput <= studentTotal && numberInput >= 1)
        {
            Console.WriteLine(nameArray[numberInput - 1]);
            ArrayOptions(hometownArray, faveFoodArray, numberInput);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    } while (true);
}

void ArrayOptions (string[] hometownArray, string[] faveFoodArray, int numberInput)
{
    do
    {
        Console.WriteLine($"Would you like to know their favorite food or hometown?");
        string arraySelection = Console.ReadLine().ToLower();

        if (arraySelection == "hometown" || hometownString.ToLower().Contains(arraySelection)) // if user types hometown OR if the hometownstring contains any characters found in what the user inputs
        {
            Console.WriteLine(hometownArray[numberInput - 1]);
            Console.WriteLine("\nWould you like to know their favorite food, too? (y/n)");
            string nextArray = Console.ReadLine().ToLower();

            if (nextArray == "y" || nextArray == "yes")
            {
                Console.WriteLine(faveFoodArray[numberInput - 1]);
                ContinueWithDeets();
                break;
            }
            else
            {
                ContinueWithDeets();
                break;
            }
        }
        else if (arraySelection == "favorite food" || faveFoodString.ToLower().Contains(arraySelection))
        {
            Console.WriteLine(faveFoodArray[numberInput - 1]);
            Console.WriteLine("\nWould you like to know their hometown too? (y/n)");
            string nextArray = Console.ReadLine().ToLower();

            if (nextArray == "y" || nextArray == "yes")
            {
                Console.WriteLine(hometownArray[numberInput - 1]);
                ContinueWithDeets();
                break;
            }
            else
            {
                ContinueWithDeets();
                break;
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Invalid input. Please enter 'hometown' or 'favorite food'.");
        }

    } while (true);
}

void StudentList (string[] nameArray)
{
    foreach (string student in nameArray)
    {
        Console.WriteLine(student);
    }

    Console.WriteLine("\nPress any key to return to the menu");
    Console.ReadKey();
    Menu();
}

void Menu()
{
    bool isValidInput = true; // establishing variable before its used in do-while loop

    int menuSelect;

    Console.WriteLine("-------- MENU ---------");
    Console.WriteLine("Please input the number of the function you'd like to run:");
    Console.WriteLine("1. Student Details");
    Console.WriteLine("2. Student List");
    Console.WriteLine("3. Exit program");
    Console.WriteLine("-----------------------");

    do // validation - checking to see if user input an integer
    {
        isValidInput = int.TryParse(Console.ReadLine(), out menuSelect);
        if (isValidInput == false)
        {
            Console.Clear();
            Console.WriteLine("Invalid input. Please enter a valid number option.");
        }
    }
    while (isValidInput == false);

    Console.Clear();

    switch (menuSelect)
    {
        case 1:
            StudentDeets(nameArray);
            break;

        case 2:
            StudentList(nameArray);
            break;

        case 3:
            Console.WriteLine("\nYou've chosen to exit the program. Goodbye!");
            Environment.Exit(0);
            break;

        default: // fallback if user doesn't select any of the 1-4 menu options
            Console.Clear();
            Console.WriteLine("Invalid option. Please input the number of the method you'd like to run.");
            break;
    }
}

void ContinueWithDeets()
{

bool returnToMenu = true;
int returnSelect;

Console.WriteLine("\nWhat would you like to do next?");
Console.WriteLine("1. Continue with student details");
Console.WriteLine("2. Return to menu");

    do // validation - checking to see if user input an integer
    {
        returnToMenu = int.TryParse(Console.ReadLine(), out returnSelect);
        if (returnToMenu == false)
        {
            Console.Clear();
            Console.WriteLine("Invalid input. Please enter a valid number option.");
        }
    }
    while (returnToMenu == false);

    switch (returnSelect)
    {
        case 1:
            StudentDeets(nameArray);
            break;

        case 2:
            Menu();
            break;

        default:
            Console.Clear();
            Console.WriteLine("Invalid option. Please input a valid number.");
            break;
    }
}


Menu();