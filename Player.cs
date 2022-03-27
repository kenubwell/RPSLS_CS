using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS

{
    public class Player
    {
        public string name;
        public string gestureSelected;
        public int wins;
        public string[] gestureList = { "rock", "paper", "scissors", "lizard", "spock" };
    }
}