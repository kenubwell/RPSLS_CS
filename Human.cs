using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{

	public class Human : Player
	{
		public Human()
		{

		}

		public string setName()
        {
			Console.WriteLine("Please enter in a player name: ");
			string userName = Console.ReadLine();
        }

		public string chooseGesture()
        {
			bool gestureConfirmed = false;
			Console.WriteLine("Enter in '0' for " this.gestureList[0]);
			Console.WriteLine("Enter in '1' for " this.gestureList[1]);
			Console.WriteLine("Enter in '2' for " this.gestureList[2]);
			Console.WriteLine("Enter in '3' for " this.gestureList[3]);
			Console.WriteLine("Enter in '4' for " this.gestureList[4]);

			while (gestureConfirmed = false)
            {
				Console.WriteLine("Enter in the number (gesture) you want to use: ");
				int selectedGesture = Console.Readline(); 
				if (selectedGesture >= 0 && selectetGesture <= 4)
                {
					if (selectedGesture == 0)
                    {
						this.gesteredSelected = this.gestureList[0];
						Console.Writeline("Gesture recorded.");
						gestureConfirmed = true;
					}
					else if (selectedGesture == 1)
                    {
						this.gestredSelected = this.gestureList[1]; 
						Console.Writeline("Gesture recorded.")
						gestureConfirmed = true;
					}
					else if (selectedGesture == 2)
					{
						this.gestredSelected = this.gestureList[2];
						Console.Writeline("Gesture recorded.")
						gestureConfirmed = true;
					}
					else if (selectedGesture == 3)
					{
						this.gestredSelected = this.gestureList[3];
						Console.Writeline("Gesture recorded.")
						gestureConfirmed = true;
					}
					else if (selectedGesture == 4)
					{
						this.gestredSelected = this.gestureList[4];
						Console.Writeline("Gesture recorded.")
						gestureConfirmed = true;
					}
			
				}
				else
				{
					Console.WriteList("Invalid Entry.")
					Console.WriteList("Please make sure to type a number between '0' and '4' per instructions above.")
				}
			}

		}
	}
}