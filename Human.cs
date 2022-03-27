using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{

	public class Human : Player
	{
		public Human(string name, string gestureSelected, string[] gestureList, int wins)
		{
			this.name = name;
			this.gestureSelected = gestureSelected;
			this.gestureList = gestureList;
			this.wins = wins;

		}


		public void setName()
        {
			Console.WriteLine("Please enter in a player name: ");
			this.name = Console.ReadLine();
        }


		public void chooseGesture()
        {
			bool gestureConfirmed = false;

			Console.WriteLine($"Enter in '0' for {this.gestureList[0]}");
			Console.WriteLine($"Enter in '1' for {this.gestureList[1]}");
			Console.WriteLine($"Enter in '2' for {this.gestureList[2]}");
			Console.WriteLine($"Enter in '3' for {this.gestureList[3]}");
			Console.WriteLine($"Enter in '4' for {this.gestureList[4]}");

			while (gestureConfirmed == false)
            {
				Console.WriteLine("Enter in the number (gesture) you want to use: ");
				int selectedGesture = int.Parse(Console.ReadLine()); 
				if (selectedGesture >= 0 && selectedGesture <= 4)
                {
					if (selectedGesture == 0)
                    {
						this.gestureSelected = this.gestureList[0];
						Console.WriteLine("Gesture recorded.");
						gestureConfirmed = true;
					}
					else if (selectedGesture == 1)
                    {
						this.gestureSelected = this.gestureList[1];
						Console.WriteLine("Gesture recorded.");
						gestureConfirmed = true;
					}
					else if (selectedGesture == 2)
					{
						this.gestureSelected = this.gestureList[2];
						Console.WriteLine("Gesture recorded.");
						gestureConfirmed = true;
					}
					else if (selectedGesture == 3)
					{
						this.gestureSelected = this.gestureList[3];
						Console.WriteLine("Gesture recorded.");
						gestureConfirmed = true;
					}
					else if (selectedGesture == 4)
					{
						this.gestureSelected = this.gestureList[4];
						Console.WriteLine("Gesture recorded.");
						gestureConfirmed = true;
					}
			
				}
				else
				{
					Console.WriteLine("Invalid Entry.");
					Console.WriteLine("Please make sure to type a number between '0' and '4' per instructions above.");
				}
			}

		}
	}
}