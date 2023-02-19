using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> myDic = new Dictionary<string, string>()
            {
                {"originkey", "originvalue" },
                {"originkey2", "originvalue2" }
            };

            myDic.Add("addkey", "addvalue");
            myDic["thekey"] = "thevalue";

            System.Console.WriteLine(myDic["originkey"]);
            System.Console.WriteLine(myDic["originkey2"]);
            System.Console.WriteLine(myDic["addkey"]);
            System.Console.WriteLine(myDic["thekey"]);
        }
    }
}
