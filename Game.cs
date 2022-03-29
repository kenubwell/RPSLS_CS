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
						aiGameRound(playerOne, playerTwo);
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
						humanGameRound(playerOne, playerTwo);
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

		public void humanGameRound(Human playerOne, Human playerTwo)
		{
			int roundCount = 1;

			while (playerOne.wins < 2 && playerTwo.wins < 2)
			{
				if (playerOne.gestureSelected == playerTwo.gestureSelected)
				{
					Console.WriteLine($"This round is a tie you both had {playerTwo.gestureSelected}");
				}
				else if (playerOne.gestureSelected == playerOne.gestureList[0] && playerTwo.gestureSelected == playerTwo.gestureList[2])
				{
					playerOne.wins += 1;
					roundCount += 1;
					Console.WriteLine($"{ playerOne.name} won this round by having {playerOne.gestureList[0]} over {playerTwo.name}'s {playerTwo.gestureList[2]}");
				}
				else if (playerOne.gestureSelected == playerOne.gestureList[0] && playerTwo.gestureSelected == playerTwo.gestureList[3])
				{
					playerOne.wins += 1;
					roundCount += 1;
					Console.WriteLine($"{ playerOne.name} won this round by having {playerOne.gestureList[0]} over {playerTwo.name}'s {playerTwo.gestureList[3]}");
				}
				else if (playerOne.gestureSelected == playerOne.gestureList[2] && playerTwo.gestureSelected == playerTwo.gestureList[1])
				{
					playerOne.wins += 1;
					roundCount += 1;
					Console.WriteLine($"{ playerOne.name} won this round by having {playerOne.gestureList[2]} over {playerTwo.name}'s {playerTwo.gestureList[1]}");
				}
				else if (playerOne.gestureSelected == playerOne.gestureList[2] && playerTwo.gestureSelected == playerTwo.gestureList[3])
				{
					playerOne.wins += 1;
					roundCount += 1;
					Console.WriteLine($"{ playerOne.name} won this round by having {playerOne.gestureList[2]} over {playerTwo.name}'s {playerTwo.gestureList[3]}");
				}
				else if (playerOne.gestureSelected == playerOne.gestureList[1] && playerTwo.gestureSelected == playerTwo.gestureList[0])
				{
					playerOne.wins += 1;
					roundCount += 1;
					Console.WriteLine($"{ playerOne.name} won this round by having {playerOne.gestureList[1]} over {playerTwo.name}'s {playerTwo.gestureList[0]}");
				}
				else if (playerOne.gestureSelected == playerOne.gestureList[1] && playerTwo.gestureSelected == playerTwo.gestureList[4])
				{
					playerOne.wins += 1;
					roundCount += 1;
					Console.WriteLine($"{ playerOne.name} won this round by having {playerOne.gestureList[1]} over {playerTwo.name}'s {playerTwo.gestureList[4]}");
				}
				else if (playerOne.gestureSelected == playerOne.gestureList[3] && playerTwo.gestureSelected == playerTwo.gestureList[4])
				{
					playerOne.wins += 1;
					roundCount += 1;
					Console.WriteLine($"{ playerOne.name} won this round by having {playerOne.gestureList[3]} over {playerTwo.name}'s {playerTwo.gestureList[4]}");
				}
				else if (playerOne.gestureSelected == playerOne.gestureList[3] && playerTwo.gestureSelected == playerTwo.gestureList[1])
				{
					playerOne.wins += 1;
					roundCount += 1;
					Console.WriteLine($"{ playerOne.name} won this round by having {playerOne.gestureList[3]} over {playerTwo.name}'s {playerTwo.gestureList[1]}");
				}
				else if (playerOne.gestureSelected == playerOne.gestureList[4] && playerTwo.gestureSelected == playerTwo.gestureList[2])
				{
					playerOne.wins += 1;
					roundCount += 1;
					Console.WriteLine($"{ playerOne.name} won this round by having {playerOne.gestureList[4]} over {playerTwo.name}'s {playerTwo.gestureList[2]}");
				}
				else if (playerOne.gestureSelected == playerOne.gestureList[4] && playerTwo.gestureSelected == playerTwo.gestureList[0])
				{
					playerOne.wins += 1;
					roundCount += 1;
					Console.WriteLine($"{ playerOne.name} won this round by having {playerOne.gestureList[4]} over {playerTwo.name}'s {playerTwo.gestureList[0]}");
				}
                else
                {
					roundCount += 1;
					playerTwo.wins += 1;
					Console.WriteLine($"{ playerTwo.name} won this round by having {playerTwo.gestureSelected} over {playerOne.name}'s {playerOne.gestureSelected}");

				}
			}
			huDisplayWinner(playerOne, playerTwo);
		}
		public void aiGameRound(Human playerOne, AI playerTwo)
		{
			int roundCount = 1;

			while (playerOne.wins < 2 && playerTwo.wins < 2)
			{
				if (playerOne.gestureSelected == playerTwo.gestureSelected)
				{
					Console.WriteLine($"This round is a tie you both had {playerTwo.gestureSelected}");
				}
				else if (playerOne.gestureSelected == playerOne.gestureList[0] && playerTwo.gestureSelected == playerTwo.gestureList[2])
				{
					playerOne.wins += 1;
					roundCount += 1;
					Console.WriteLine($"{ playerOne.name} won this round by having {playerOne.gestureList[0]} over {playerTwo.name}'s {playerTwo.gestureList[2]}");
				}
				else if (playerOne.gestureSelected == playerOne.gestureList[0] && playerTwo.gestureSelected == playerTwo.gestureList[3])
				{
					playerOne.wins += 1;
					roundCount += 1;
					Console.WriteLine($"{ playerOne.name} won this round by having {playerOne.gestureList[0]} over {playerTwo.name}'s {playerTwo.gestureList[3]}");
				}
				else if (playerOne.gestureSelected == playerOne.gestureList[2] && playerTwo.gestureSelected == playerTwo.gestureList[1])
				{
					playerOne.wins += 1;
					roundCount += 1;
					Console.WriteLine($"{ playerOne.name} won this round by having {playerOne.gestureList[2]} over {playerTwo.name}'s {playerTwo.gestureList[1]}");
				}
				else if (playerOne.gestureSelected == playerOne.gestureList[2] && playerTwo.gestureSelected == playerTwo.gestureList[3])
				{
					playerOne.wins += 1;
					roundCount += 1;
					Console.WriteLine($"{ playerOne.name} won this round by having {playerOne.gestureList[2]} over {playerTwo.name}'s {playerTwo.gestureList[3]}");
				}
				else if (playerOne.gestureSelected == playerOne.gestureList[1] && playerTwo.gestureSelected == playerTwo.gestureList[0])
				{
					playerOne.wins += 1;
					roundCount += 1;
					Console.WriteLine($"{ playerOne.name} won this round by having {playerOne.gestureList[1]} over {playerTwo.name}'s {playerTwo.gestureList[0]}");
				}
				else if (playerOne.gestureSelected == playerOne.gestureList[1] && playerTwo.gestureSelected == playerTwo.gestureList[4])
				{
					playerOne.wins += 1;
					roundCount += 1;
					Console.WriteLine($"{ playerOne.name} won this round by having {playerOne.gestureList[1]} over {playerTwo.name}'s {playerTwo.gestureList[4]}");
				}
				else if (playerOne.gestureSelected == playerOne.gestureList[3] && playerTwo.gestureSelected == playerTwo.gestureList[4])
				{
					playerOne.wins += 1;
					roundCount += 1;
					Console.WriteLine($"{ playerOne.name} won this round by having {playerOne.gestureList[3]} over {playerTwo.name}'s {playerTwo.gestureList[4]}");
				}
				else if (playerOne.gestureSelected == playerOne.gestureList[3] && playerTwo.gestureSelected == playerTwo.gestureList[1])
				{
					playerOne.wins += 1;
					roundCount += 1;
					Console.WriteLine($"{ playerOne.name} won this round by having {playerOne.gestureList[3]} over {playerTwo.name}'s {playerTwo.gestureList[1]}");
				}
				else if (playerOne.gestureSelected == playerOne.gestureList[4] && playerTwo.gestureSelected == playerTwo.gestureList[2])
				{
					playerOne.wins += 1;
					roundCount += 1;
					Console.WriteLine($"{ playerOne.name} won this round by having {playerOne.gestureList[4]} over {playerTwo.name}'s {playerTwo.gestureList[2]}");
				}
				else if (playerOne.gestureSelected == playerOne.gestureList[4] && playerTwo.gestureSelected == playerTwo.gestureList[0])
				{
					playerOne.wins += 1;
					roundCount += 1;
					Console.WriteLine($"{ playerOne.name} won this round by having {playerOne.gestureList[4]} over {playerTwo.name}'s {playerTwo.gestureList[0]}");
				}
				else
				{
					roundCount += 1;
					playerTwo.wins += 1;
					Console.WriteLine($"{ playerTwo.name} won this round by having {playerTwo.gestureSelected} over {playerOne.name}'s {playerOne.gestureSelected}");

				}
			}
			aiDisplayWinner(playerOne, playerTwo);
		}

		public void huDisplayWinner(Human playerOne, Human playerTwo)
        {
			if (playerOne.wins == 2)
            {
				Console.WriteLine($"{playerOne.name} wins the game!");
				Console.WriteLine($"Summary of the game: The Winner {playerOne.name} had {playerOne.wins} || The Loser {playerTwo.name} had {playerTwo.wins}");
            }
			else if (playerTwo.wins == 2)
            {
				Console.WriteLine($"{playerTwo.name} wins the game!");
				Console.WriteLine($"Summary of the game: The Winner {playerTwo.name} had {playerTwo.wins} || The Loser {playerOne.name} had {playerOne.wins}");
			}
        }
		public void aiDisplayWinner(Human playerOne, AI playerTwo)
		{
			if (playerOne.wins == 2)
			{
				Console.WriteLine($"{playerOne.name} wins the game!");
				Console.WriteLine($"Summary of the game: The Winner {playerOne.name} had {playerOne.wins} || The Loser {playerTwo.name} had {playerTwo.wins}");
			}
			else if (playerTwo.wins == 2)
			{
				Console.WriteLine($"{playerTwo.name} wins the game!");
				Console.WriteLine($"Summary of the game: The Winner {playerTwo.name} had {playerTwo.wins} || The Loser {playerOne.name} had {playerOne.wins}");
			}
		}
	}

}
