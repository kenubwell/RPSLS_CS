using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RPSLS
{

	public class AI : Player
	{
		public AI()
		{
			this.name = name;
			this.gestureSelected = gestureSelected;
			this.gestureList = gestureList;
			this.wins = wins;
		}

		public void setName()
        {
			this.name = "SkyNet";
        }


		public void chooseGesture()
        {
			Console.WriteLine("Ai's gesture is...");
			Thread.Sleep(2000);

			var rand = new Random();
			int num = rand.Next(5);
			if (num == 0)
            {
				this.gestureSelected = this.gestureList[0];
				Console.WriteLine(this.gestureSelected);
			}
			else if (num == 1)
            {
				this.gestureSelected = this.gestureList[1];
				Console.WriteLine(this.gestureSelected);
			}
			else if (num == 2)
			{
				this.gestureSelected = this.gestureList[2];
				Console.WriteLine(this.gestureSelected);
				}
			else if (num == 3)
			{
				this.gestureSelected = this.gestureList[3];
				Console.WriteLine(this.gestureSelected);
				}
			else if (num == 4)
			{
				this.gestureSelected = this.gestureList[4];
				Console.WriteLine(this.gestureSelected);
			}
		}
	}
}
