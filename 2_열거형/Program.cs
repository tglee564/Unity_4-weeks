using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_열거형
{
    class Program
    {
        static void Main(string[] args)
        {
            theplayerstate mystate = theplayerstate.idle;

            switch(mystate)
            {
                case theplayerstate.idle:
                    Console.WriteLine("I'm idle");
                    break;
                case theplayerstate.walk:
                    Console.WriteLine("I'm walk");
                    break;
                case theplayerstate.run:
                    Console.WriteLine("I'm run");
                    break;
            }

        }
    }
}
public enum theplayerstate
{
    idle,
    walk,
    run
}
