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
		public void game()
		{
			Human playerOne = new Human();
		}

		public void runGame()
        {
			this.displayWelcome();
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
	}

}
