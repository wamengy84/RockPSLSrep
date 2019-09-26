using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLSproject
{
    class GamePlay
    {

        //member variable(has a)
        public string playerNumberOne;
        public string playerNumberTwo;
       


        //constructor(spawner)
        public GamePlay()
        {
            
        }

        //member method(can do)
        public void RunGame() //Master run game method
        {
            DisplayGameRules();
        
        
        
        
        
        }
        public void DisplayGameRules()
        {
            Console.WriteLine("Rock crushes Scissor");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Scissor cuts Paper");
            Console.WriteLine("Scissor decapitates Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Spock smashes Scissor");
            Console.WriteLine("Spock vaporizes Rock");
            Console.WriteLine("Best out of 3 rounds wins");
            
        }
       
        
    }
}
