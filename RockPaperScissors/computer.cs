using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Computer : Player 
    {
        public override void MakeChoice()
        {
                Random rnd = new Random();
            
            string[] Choice = { "Rock", "Paper", "Scissors", "Lizard", "Spok" };
            int index = rnd.Next(0,5); 

                Console.WriteLine("{0}", Choice[index]);
                 



             

               





            
            
        }
    }

}
