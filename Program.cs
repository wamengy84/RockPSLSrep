using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLSproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissor, Lizard, Spock!!!");
            GamePlay rockPaper = new GamePlay();
            Player playerName = new Player();
            rockPaper.RunGame();
            playerName.Run();
            Console.ReadLine();
            

           
        }
    }
}
