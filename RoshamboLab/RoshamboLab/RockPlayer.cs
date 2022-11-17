//3.Create and name three player subclasses:
///		a. RockPlayer - Always throws Rock
//		b. RandomPlayer - Picks and throws a value at random
//		c. HumanPlayer - Allows the user to select and throw a value. Upon creating an
//		instance of this class, allow the user to input their name.

namespace RoshamboLab
{
    public class RockPlayer : Player
    {
        public RockPlayer()
        {
            name = "Rocko";
            roshambo = Roshambo.Rock;
        }

        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }

        public string ReturnRockPlayerNameAndWeapon(RockPlayer rockPlayer)
        {
            Roshambo rockPlayerWeapon = rockPlayer.GenerateRoshambo();

            string RockPlayerPlayed = ($"{rockPlayer.name} played {rockPlayerWeapon}");

            return RockPlayerPlayed;
        }
    }
}
