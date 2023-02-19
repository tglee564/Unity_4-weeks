using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_정보_Property_
{
    class Program
    {
        static void Main(string[] args)
        {
            playername playername = new playername();
            //playername.name = "ttt";                // set (외부에서 수정 불가)
            Console.WriteLine(playername.name);     // get (가져와서 사용만 가능)
        }
    }
    class playername
    {
        public string name { get; private set; }
    }
}
