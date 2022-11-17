// 1.Create an enumeration called Roshambo that has three values: rock, paper, and scissors.

namespace RoshamboLab
{
    public enum Roshambo
    {
        Rock = 1, // Setting index for enum at 1
        Paper,
        Scissors
    }

    // 2. Create an abstract class named Player that stores a name and a Roshambo value.
    // This class should include a method named GenerateRoshambo that allows an inheriting
    // class to generate and return a Roshambo value.
    public abstract class Player
    {
        public string name;
        protected Roshambo roshambo;
        protected int score;
        private int wins = 0;
        private int losses = 0;


        public abstract Roshambo GenerateRoshambo();


        public string GetName()
        {
            return name;
        }


        public bool PlayerWins(Player obj)
        {
            if (roshambo == obj.roshambo)
            {
                return false;
            }
            else if (roshambo == Roshambo.Paper && obj.roshambo == Roshambo.Rock) //Paper beats rock
            {
                wins++;
                return true;
            }
            else if (roshambo == Roshambo.Rock && obj.roshambo == Roshambo.Scissors) //Rock beats scissors
            {
                wins++;
                return true;
            }
            else if (roshambo == Roshambo.Scissors && obj.roshambo == Roshambo.Paper) //Scissor beats paper
            {
                wins++;
                return true;
            }
            losses++;
            return false;
        }


        public int GetWins()
        {
            return wins;
        }

        public void Lost()
        {
            losses++;
        }
    }
}