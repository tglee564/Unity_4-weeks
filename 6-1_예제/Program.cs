using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 1, 2, 3, 4, 5 };
            List<string> stringList = new List<string>() { "불", "물", "바람", "전기", "바위" };
            List<float> floatList = new List<float>() { 1.3f, 1.9f, 2.6f, 3.3f, 4.5f };

            for (int index = 0; index < intList.Count; index++)
            {
                Console.WriteLine(intList[index]);
            }
            Console.WriteLine("---------------------------------------------");
            for (int index = 0; index < stringList.Count; index++)
            {
                Console.WriteLine(stringList[index]);
            }
            Console.WriteLine("---------------------------------------------");
            for (int index = 0; index < floatList.Count; index++)
            {
                Console.WriteLine(floatList[index]);
            }
            Console.WriteLine("---------------------------------------------");

            List<City> cityList = new List<City>();

            City Seoul = new City();
            Seoul.name = "Seoul";

            City Dokyo = new City();
            Dokyo.name = "Dokyo";

            City Paris = new City();
            Paris.name = "Paris";

            City Inchoen = new City();
            Inchoen.name = "Inchoen";

            City London = new City();
            London.name = "London";

            cityList.Add(Seoul);
            cityList.Add(Dokyo);
            cityList.Add(Paris);
            cityList.Add(Inchoen);
            cityList.Add(London);


            for (int index = 0; index < cityList.Count; index++)
            {
                cityList[i].IntroduceCity();
            }

            Console.WriteLine("---------------------------------------------");
        }
        class City
        {
            public string name;
            public void IntroduceCity()
            {
                System.Console.WriteLine($"This city is {name}");
            }
        }
    }
}
