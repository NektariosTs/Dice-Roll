
using DiceRollGame.Game.UserCommunication;

namespace DiceRollGame.Game
{
    public class GuessingGame
    {
        private readonly Dice _dice;
        private const int InitialTries = 3;

        public GuessingGame(Dice dice)
        {
            _dice = dice;
        }

        public GameResult Play()
        {
            var diceRollResult = _dice.Roll();
            Console.WriteLine(
                $"Dice rolled.Guess what number it shows in {InitialTries} tries.");

            var triesLeft = InitialTries;
            while (triesLeft > 0)
            {
                var guess = ConsoleReader.ReadInteger("Enter a number:");
                if (guess == diceRollResult)
                {
                    return GameResult.Victory;
                }

                Console.WriteLine("Wrong number");
                --triesLeft;
            }
            return GameResult.Loss;
        }

        public static void PrintResult(GameResult gameResult)
        {
            //string message;                  KANONIKOS TROPOS
            //if (gameResult == GameResult.Victory)
            //{
            //    message = ("You win!");
            //}
            //else
            //{
            //    message = ("You lose :(");
            //}
            //Console.WriteLine(message);

            string message = gameResult == GameResult.Victory ? "You win!" : "You lose:(";
            Console.WriteLine(message);//TERNARY Condiotional oparetor (apofeygoume olo to if else statment kai to kanoume se mia grammh)
        }
    }
}
