using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_랜덤
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int Randomint = rand.Next(0, 10);

            Console.WriteLine("0~10사이 랜덤 : " + Randomint);
        }
    }
}
