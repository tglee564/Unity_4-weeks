using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _5_2_예제
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 생명체 인터페이스 생성.
            //2. 생명체에는 공격하기,공격받기,회피하기,피해받기 가 있음.
            //3. 생명체에는 플레이어와 몬스터 2개가 상속
            //4. 플레이어와 몬스터가 둘중 하나가 죽을때까지 계속 공격하고 받기를 주고받음.(While문 참고)
            //5. 공격하면 공격한다고 출력
            //6. 공격받는 대상은 확률(랜덤)로 회피 또는 피해 받기를 실행
            //7. 플레이어와 몬스터 둘다 이렇게 진행

            Player player = new Player();
            Monster monster = new Monster();

            while(player.hp != 0 && monster.hp != 0)
            {
                player.Attack(monster);
                Thread.Sleep(500);
                System.Console.WriteLine();
                monster.Attack(player);
                Thread.Sleep(500);
                System.Console.WriteLine();
            }

            if(player.hp == 0)
            {
                System.Console.WriteLine("플레이어가 사망하였습니다!!");
            }

            if(monster.hp == 0)
            {
                System.Console.WriteLine("몬스터를 쓰러트림!!");
            }

        }
        //1. 생명체 인터페이스 생성.
        interface Entity
        {
            //2. 생명체에는 공격하기,공격받기,회피하기,피해받기 가 있음.
            void Attack(Entity entity); //공격하기
            void TakeDamage(); //공격받기
            void Avoid(); //회피하기
            void ReduceHP(); //피해받기
        }
        class Player : Entity
        {
            public int hp = 3;
            public void Attack(Entity entity)
            {
                System.Console.WriteLine("플레이어가 몬스터를 공격함!!");
                entity.TakeDamage();
            }

            public void Avoid()
            {
                System.Console.WriteLine("플레이어가 회피함!");
            }

            public void ReduceHP()
            {
                hp--;
                System.Console.WriteLine($"플레이어가 데미지를 입음! 플레이어 체력 : {hp}");
            }

            public void TakeDamage()
            {
                Random rand = new Random();
                int randint = rand.Next(0, 2);
                if (randint == 0) //0인 경우 데미지 안받음
                {
                    Avoid();
                }
                else // 1인 경우 데미지 받음
                {
                    ReduceHP();
                }
            }
        }
        class Monster : Entity
        {
            public int hp = 3;
            public void Attack(Entity entity)
            {
                System.Console.WriteLine("몬스터가 플레이어를 공격함!!");
                entity.TakeDamage();
            }

            public void Avoid()
            {
                System.Console.WriteLine("몬스터가 회피함!");
            }

            public void ReduceHP()
            {
                hp--;
                System.Console.WriteLine($"몬스터가 데미지를 입음! 몬스터 체력 : {hp}");
            }

            public void TakeDamage()
            {
                Random rand = new Random();
                int randint = rand.Next(0, 2);
                if(randint == 0) //0인 경우 데미지 안받음
                {
                    Avoid();
                }
                else // 1인 경우 데미지 받음
                {
                    ReduceHP();
                }
            }
        }
    }
}
