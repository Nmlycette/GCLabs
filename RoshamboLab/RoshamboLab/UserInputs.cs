using System.Xml.Linq;

namespace RoshamboLab
{
    public class UserInputs
    {
        public static bool ValidateString(string name)
        {
            if (String.IsNullOrEmpty(name) || name.Any(c => char.IsDigit(c)))
            {
                Console.WriteLine("Input cannot be empty or include digits.");
                return false;
            }
            return true;
        }

        public static string GetUserInput(string message, bool strict = true)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (input == string.Empty && strict)
            {
                return GetUserInput(message);
            }
            return input;
        }


        public static int IntCatcherAndValidator(string numberForSelection)
        {
            bool isInt = false;
            int userInputInt = 0;

            do
            {
                Console.WriteLine($"Input the number of your selected {numberForSelection}");
                isInt = int.TryParse(Console.ReadLine(), out userInputInt);
                if (isInt == false)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.\n");
                }
                if (isInt == true && numberForSelection == "weapon")
                {
                    if (userInputInt >= 1 && userInputInt<= 3)
                    {
                        return userInputInt;
                    }
                    else
                    {
                        Console.WriteLine($"Enter a number 1-3 to select your {numberForSelection})");
                        isInt = false;
                    }
                }
                if (isInt == true && numberForSelection == "opponent")
                {
                    if (userInputInt == 1 || userInputInt == 2)
                    {
                        return userInputInt;
                    }
                    else
                    {
                        Console.WriteLine($"Enter number 1 or 2 to select your {numberForSelection})");
                        isInt = false;
                    }
                }
            }
            while (isInt == false);
            return userInputInt;
        }
    }
}