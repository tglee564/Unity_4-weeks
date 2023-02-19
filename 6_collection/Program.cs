using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //List
            //배열 int[] intarray = new int[3];
            List<int> IntList = new List<int>() { 6, 2, 4, 6 }; //배열과 비슷하나 크기를 늘릴 수 있음.

            IntList.Add(7);  //()안의 값을 추가
            IntList.Add(91); //()안의 값을 추가

            for (int index = 0; index < IntList.Count; index++)
            {
                Console.WriteLine(IntList[index]);
            }

            Console.WriteLine("---------------------------------------------");

            IntList.Remove(7); //()안의 값과 같은 값을 삭제

            for (int index = 0; index < IntList.Count; index++)
            {
                Console.WriteLine(IntList[index]);
            }

            Console.WriteLine("---------------------------------------------");

            IntList.Insert(3, 9); //3번째에 9라는 값을 추가

            for (int index = 0; index < IntList.Count; index++)
            {
                Console.WriteLine(IntList[index]);
            }

            Console.WriteLine("---------------------------------------------");

            IntList.Clear(); // 값을 모두 삭제함.

            for (int index = 0; index < IntList.Count; index++)
            {
                Console.WriteLine(IntList[index]);
            }

            Console.WriteLine("---------------------------------------------");
        }
    }
}
