using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Human : Players
    {
        public override void MakeChoice()
        {
            Console.WriteLine("Rock", "Paper", "scissors","Spok","Lizard");
            Console.WriteLine("plase make a selection \n");
            string Choice = Console.ReadLine();

            switch (Choice)
            {
                case "Rock":
                    Console.WriteLine("good luck!");
                    break;
                case "paper":
                    Console.WriteLine("good luck!");
                    break;
            }
            
        }
        


    }
}
