using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Game
    {
        //member variable (HAS A)
        public Player player1;
        public Player player2;


            




        //constructor 




        //member method (CAN DO)
        public void SetPlayers()
        {
            player1 = new Human();
            player1.MakeChoice();
        }
    }
}
