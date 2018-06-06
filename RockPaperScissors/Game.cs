using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Game
    {
        public Player player1;
        public Player player2;


        public Game()
        {
            player1 = new Human();
            //player2 = new Computer();

        }

        public void RunGame()
        {
            SetPlayers();
            player1.MakeChoice();
            player2.MakeChoice();
        }


        public void SetPlayers()
        {

            Console.WriteLine("Human, Computer");
            Console.WriteLine("plase make a selection \n");
            string player = Console.ReadLine();

            switch (player)
            {
                case "Human":
                    Console.WriteLine("Begin!");
                    player2 = new Human();
                    break;
                case "Computer":
                    Console.WriteLine("begin!");
                    player2 = new Computer();
                    break;
                default:
                    Console.WriteLine("not an appropriate choice try again");
                    break;
            }


                
                 //// player1.MakeChoice();
                 //    player2 = new Computer();
                //// player2.MakeChoice();

                //    player1 = new Human();
                //// player1.MakeChoice();
                //    player2 = new Human();
                //// player2.MakeChoice();
                      
        }

        //public string gestures = null;
        //private object payer2;
    }
}
