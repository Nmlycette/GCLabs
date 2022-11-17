//3.Create and name three player subclasses:
//		a. RockPlayer - Always throws Rock
///		b. RandomPlayer - Picks and throws a value at random
//		c. HumanPlayer - Allows the user to select and throw a value. Upon creating an
//		instance of this class, allow the user to input their name.

namespace RoshamboLab
{
    public class RandomPlayer : Player
    {
        public RandomPlayer()
        {
            name = "Randy";
        }

        public override Roshambo GenerateRoshambo()
        {
            roshambo = (Roshambo)new Random().Next(3) + 1;
            return roshambo;
        }


        public string ReturnRandomPlayerNameAndWeapon(RandomPlayer randomPlayer)
        {
            Roshambo randomPlayerWeapon = randomPlayer.GenerateRoshambo();

            string RandomPlayerPlayed = ($"{randomPlayer.name} played {randomPlayerWeapon}");

            return RandomPlayerPlayed;
        }
    }
}