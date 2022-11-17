bool validEntry = false;
bool playAgain;
int diceSides;
string rollComboResult;
string rollTotalResult;
string otherSidedComboResult;

do {
    do
    {
        Console.WriteLine("How many sides are your dice?");
        validEntry = int.TryParse(Console.ReadLine(), out diceSides);
        if (validEntry == false)
        {
            Console.WriteLine("Invalid entry. Please enter a number.");
        }
    } while (validEntry == false); // checking to see if user input an integer

    Console.WriteLine("Press any key to roll your dice");
    Console.ReadKey();

    var numberGeneratorReturn = numberGenerator(diceSides);

    int rollOneOuput = numberGeneratorReturn.Item1;
    int rollTwoOutput = numberGeneratorReturn.Item2;
    int rollTotalOutput = numberGeneratorReturn.Item3;
    Console.WriteLine($"Roll 1: {rollOneOuput}\nRoll 2: {rollTwoOutput}\nRoll Total: {rollTotalOutput}");

    {
        if (diceSides == 6)
        {
            string sixSidedComboOutput = SixSidedCombos(rollOneOuput, rollTwoOutput);
            string sixSidedTotalOutput = SixSidedTotals(rollTotalOutput);
            Console.WriteLine($"{sixSidedComboOutput}\n{sixSidedTotalOutput}\n");
        }
        else
        {
            string otherSidedOutput = OtherSidedCombos(rollOneOuput, rollTwoOutput);
            string otherSidedTotalOutput = OtherSidedTotals(rollTotalOutput);
            Console.WriteLine($"{otherSidedOutput}\n{otherSidedTotalOutput}\n");
        }
    }
   
    Console.WriteLine("Would you like to play again (y/n)?");
    string input = Console.ReadLine();
    playAgain = input.ToLower() == "y";
    Console.Clear();

} while (playAgain == true);


//  METHODS

//  dice roll generator
(int, int, int) numberGenerator(int diceSides)
{
    Random random = new Random();

    int rollOne = random.Next(1, diceSides + 1);
    int rollTwo = random.Next(1, diceSides + 1);
    int rollTotal = (rollOne + rollTwo);

    return (rollOne, rollTwo, rollTotal);
}

//  six sided dice combos
string SixSidedCombos(int rollOne, int rollTwo)
{
    if (rollOne == 1 && rollTwo == 1 || rollOne == 1 && rollTwo == 1)
    {
        rollComboResult = "Snake eyes";
        return rollComboResult;
    }
    else if (rollOne == 1 && rollTwo == 2 || rollOne == 2 && rollTwo == 1)
    {
        rollComboResult = "Ace deuce";
        return rollComboResult;
    }
    else if (rollOne == 6 && rollTwo == 6 || rollOne == 6 && rollTwo == 6)
    {
        rollComboResult = "Box cars";
        return rollComboResult;
    }
    else
    {
        rollComboResult = "";
        return rollComboResult;
    }
}

//  six sided dice totals
string SixSidedTotals(int rollTotal)
{
    if (rollTotal == 7 || rollTotal == 11)
    {
        rollTotalResult = "Win";
        return rollTotalResult;
    }
    else if (rollTotal == 2 || rollTotal == 3 || rollTotal == 12)
    {
        rollTotalResult = "Craps";
        return rollTotalResult;
    }
    else
    {
        rollTotalResult = "";
        return rollTotalResult;
    }
}

//  other sided combos
string OtherSidedCombos(int rollOne, int rollTwo)
{

    if (rollOne == rollTwo)
    {
        otherSidedComboResult = "You rolled matching numbers!";
        return otherSidedComboResult;
    }
    else
    {
        otherSidedComboResult = "";
        return otherSidedComboResult;
    }
}

//  other sided totals
string OtherSidedTotals(int rollTotal)
{

    if (rollTotal == 7 || rollTotal == 11)
    {
        otherSidedComboResult = "Winner, winner, chicken dinner!";
        return otherSidedComboResult;
    }
    else if (rollTotal == 6 || rollTotal == 8)
    {
        otherSidedComboResult = "Bummer, so close to a winning total of 7!";
        return otherSidedComboResult;
    }
    else if (rollTotal == 10 || rollTotal == 12)
    {
        otherSidedComboResult = "Bummer, so close to a winning total of 11!";
        return otherSidedComboResult;
    }
    else
    {
        otherSidedComboResult = "";
        return otherSidedComboResult;
    }
}