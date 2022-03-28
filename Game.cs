using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RPSLS
{
	
	public class Game
	{
		public Game()
		{
			Human playerOne = new Human();
		
		}

		public void runGame()
        {
			this.displayWelcome();
			this.gameType();
        }

		public void displayWelcome()
        {
			Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock (RPSLS).");
			Console.WriteLine("Each game will be the best of three rounds a.k.a. first player to win TWICE wins the game.");
			Console.WriteLine("The following are the rules of the game:");
			Console.WriteLine("- Rock crushes Scissors");
			Console.WriteLine("- Scissors cuts Paper");
			Console.WriteLine("- Paper covers Rock");
			Console.WriteLine("- Rock crushes Lizard");
			Console.WriteLine("- Lizard poisons Spock");
			Console.WriteLine("- Spock smashes Scissors");
			Console.WriteLine("- Scissors decapitates Lizard");
			Console.WriteLine("- Lizard eats Paper");
			Console.WriteLine("- Paper disproves Spock");
			Console.WriteLine("- Spock vaporizes Rock");
		}

		public void gameType()
        {

			bool gameType = false;

			while (gameType is false)
            {
			Console.WriteLine("Enter in the game type. Press '1' for Single Player (versus AI) || or Press '2' for Multiplayer game:");
			int typeOfGame = int.Parse(Console.ReadLine());

				if (typeOfGame == 1 || typeOfGame == 2)
                {
					if (typeOfGame == 1)
                    {
						Human playerOne = new Human();
						AI playerTwo = new AI();
						playerOne.setName();
						playerTwo.setName();
						gameType = true;
					}
					else if (typeOfGame == 2)
					{
						Human playerOne = new Human();
						Human playerTwo = new Human();
						playerOne.setName();
						Console.WriteLine($"Player 1 is set for {playerOne.name}");
						playerTwo.setName();
						Console.WriteLine($"It will be Player 1 {playerOne.name} versus Player 2 {playerTwo.name}");
						gameType = true;
                    }
					
                }
				else if (typeOfGame != 1 || typeOfGame != 2)
                {
					Console.WriteLine("Invalid Entry.");
					gameType = false;
				}
            }
        }
	}

}
