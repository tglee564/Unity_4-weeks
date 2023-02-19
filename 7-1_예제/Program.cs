using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            Dictionary<String, monster> myDic = new Dictionary<string, monster>();

            monster zombie = new monster();
            zombie.name = "Zombie";

            monster goblin = new monster();
            goblin.name = "Goblin";

            monster Slime = new monster();
            Slime.name = "Slime";

            monster Seiren = new monster();
            Seiren.name = "Seiren";

            monster Durahan = new monster();
            Durahan.name = "Durahan";

            Console.WriteLine("무엇을 검색하시겠습니까?");
            string Saerch = Console.ReadLine();

            myDic["zombie"] = zombie;

            zombie.introducemonster();

            #endregion

            Dictionary<string, string> myDictionary = new Dictionary<string, string>();

            myDictionary["name"] = "제 이름은 이태근 입니다.";
            myDictionary["age"] = "제 나이는 34세 입니다.";
            myDictionary["jop"] = "제 직업은 백수 입니다.";
            myDictionary["company"] = "제 직장은 없습니다.";

            System.Console.WriteLine("검색어를 입력하세요");
            String Searchvalue = System.Console.ReadLine();

            System.Console.WriteLine(myDictionary[Searchvalue]);

        }
    }
    class monster
    {
        public string name;
        public void introducemonster()
        {
            System.Console.WriteLine($"이 몬스터의 이름은 {name}입니다.");
        }
    }

}
