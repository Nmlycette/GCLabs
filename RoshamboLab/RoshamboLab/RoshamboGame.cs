using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace RoshamboLab
{
    public class RoshamboGame
    {

        public static Player SelectOpponent()
        {
            Console.WriteLine($"1. Randy");
            Console.WriteLine($"2. Rocko");

            string numberFor = "opponent";
            int opponentChoice = UserInputs.IntCatcherAndValidator(numberFor);

            if (opponentChoice == 1)
            {
                RandomPlayer randomPlayer = new RandomPlayer();
                Console.Clear();
                return randomPlayer;
            }
            else if (opponentChoice == 2)
            {
                RockPlayer rockPlayer = new RockPlayer();
                Console.Clear();
                return rockPlayer;
            }
            return new RockPlayer();
        }


        public static Roshambo SelectWeapon()
        {
            Console.WriteLine($"1. Rock");
            Console.WriteLine($"2. Paper");
            Console.WriteLine($"3. Scissors");

            string numberFor = "weapon";
            int weaponChoice = UserInputs.IntCatcherAndValidator(numberFor);

            switch (weaponChoice)
            {
                case 1:
                    return Roshambo.Rock;
                case 2:
                    return Roshambo.Paper;
                case 3:
                    return Roshambo.Scissors;
            }
            Console.Clear();
            return Roshambo.Rock;
        }


        public void Start()
        {
            Console.Clear();
            HumanPlayer ninaPlayer = new HumanPlayer();

            bool isNameValid = false;

            do
            {
                ninaPlayer.GetHumanPlayerName();
                isNameValid = UserInputs.ValidateString(ninaPlayer.name);

            } while (isNameValid == false);


            Console.Clear();
            Player computer = SelectOpponent();

            bool repeat = false;

            do
            {
                Roshambo ninaWeapon = ninaPlayer.GenerateRoshambo();
                Roshambo computerWeapon = computer.GenerateRoshambo();

                if (ninaPlayer.PlayerWins(computer))
                {
                    Console.Clear();
                    Console.WriteLine($"{ninaPlayer.GetName()} played: {ninaWeapon}");
                    Console.WriteLine($"{computer.GetName()} played: {computerWeapon}");
                    Console.WriteLine($"{ninaPlayer.GetName()} wins!\n");
                    computer.Lost();
                    ShowGameStats(computer, ninaPlayer);
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (computer.PlayerWins(ninaPlayer))
                {
                    Console.Clear();
                    Console.WriteLine($"{ninaPlayer.GetName()} played: {ninaWeapon}");
                    Console.WriteLine($"{computer.GetName()} played: {computerWeapon}");
                    Console.WriteLine($"{computer.GetName()} wins!\n");
                    ShowGameStats(computer, ninaPlayer);
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"{ninaPlayer.GetName()} played: {ninaWeapon}");
                    Console.WriteLine($"{computer.GetName()} played: {computerWeapon}");
                    Console.WriteLine($"Draw!\n");
                    ShowGameStats(computer, ninaPlayer);
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();

                }


                bool isContinueValid = false;
                string continueInput;

                do
                {
                    Console.WriteLine("Would you like to play against again? Enter 'y' to replay.");
                    continueInput = Console.ReadLine().ToLower();
                    isContinueValid = UserInputs.ValidateString(continueInput);

                } while (isContinueValid == false);

                if (continueInput == "y" ||  continueInput == "yes")
                {
                    repeat = true;
                }
                else if (continueInput != "y" || continueInput != "yes" && repeat == false)
                {
                    Console.WriteLine("Thanks for playing!");
                    Environment.Exit(0);
                }

            } while (repeat == true);
        }


        public void ShowGameStats(Player player1, Player player2)
        {
            //Console.Write(string.Format("{0,-30}{1,-6}{2}\n", "Name", "Wins", "Losses"));
            Console.WriteLine($"{player1.GetName()} Wins: {player1.GetWins()}");
            Console.WriteLine($"{player2.GetName()} Wins: {player2.GetWins()}\n");
        }
    }
}
