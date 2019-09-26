using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLSproject
{
    class Player
    {

        //member variable(has a)
        string name;
        public int score;
        public string gesture;

        //constructor(spawner)
        public Player()
        {
            score = 0;
            name = null;
           
        }


        //member method(can do)
        public void EnterName()
        {
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
        }
        public void Run()
        {
            EnterName();
        }
    }
}
