
//var diceRollResult = random.Next(1,7);
//Console.WriteLine(diceRollResult);
//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine(random.Next(1, 11));
//}

//public enum Season
//{
//    Spring,
//    Summer,
//    Autumn,
//    Winter
//}

//Season firstSeason = Season.Spring;
//Season lastSeason = Season.Winter;
//int firstSeasonNumber = (int)firstSeason;
//int lastSeasonNumber = (int)lastSeason;

//Console.WriteLine(firstSeason);
//Console.WriteLine("As a number " + firstSeasonNumber);
//Console.WriteLine(lastSeason);
//Console.WriteLine("As a number " + lastSeasonNumber);How the enums works



using DiceRollGame.Game;

var random = new Random();
var dice = new Dice(random);
var guessingGame = new GuessingGame(dice);
GameResult gameResult = guessingGame.Play();
GuessingGame.PrintResult(gameResult);

//if (gameResult == GameResult.Victory)
//{
//    Console.WriteLine("You win!");
//}
//else
//{
//    Console.WriteLine("You lose :("); swstos tropos
//}


Console.ReadKey();


 