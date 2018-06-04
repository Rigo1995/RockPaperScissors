using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Human : Player
    {
        public override void MakeChoice()
        {

            Console.WriteLine("Rock, Paper, Scissors, Lizard, Spok");
            Console.WriteLine("plase make a selection \n");
            string Choice = Console.ReadLine();

            switch (Choice)
            {

                case "Rock":
                    Console.WriteLine("good luck!");
                    playerChoice = 0;
                    break;
                case "paper":
                    Console.WriteLine("good luck!");
                    playerChoice = 1;
                    break;
                case "scissors":
                    Console.WriteLine("good luck!");
                    playerChoice = 2;
                    break;
                case "Lizard":
                    Console.WriteLine("good luck!");
                    playerChoice = 3;
                    break;
                case "Spok":
                    Console.WriteLine("good luck!");
                    playerChoice = 4;
                    break;
                default:
                    Console.WriteLine("not an appropriate choice try again");
                    playerChoice = 5;
                    break;

            }



        }

        //    public override void MakeChoice()
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }
}