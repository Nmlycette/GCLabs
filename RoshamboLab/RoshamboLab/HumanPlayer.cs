//3.Create and name three player subclasses:
//		a. RockPlayer - Always throws Rock
//		b. RandomPlayer - Picks and throws a value at random
///		c. HumanPlayer - Allows the user to select and throw a value. Upon creating an
///		instance of this class, allow the user to input their name.

namespace RoshamboLab
{
    public class HumanPlayer : Player
    {
        public void GetHumanPlayerName()
        {
            bool isValidName = false;
            name = UserInputs.GetUserInput("What is your name:");
        }


        public override Roshambo GenerateRoshambo()
        {
            Roshambo userWeapon = RoshamboGame.SelectWeapon();
            roshambo = userWeapon;

            return userWeapon;
        }
    }
}