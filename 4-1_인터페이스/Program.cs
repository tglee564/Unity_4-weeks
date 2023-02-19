using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_인터페이스
{
    class Program
    {
        static void Main(string[] args)
        {
            player player = new player();
            darkmonster dark = new darkmonster();
            Lightmonster Light = new Lightmonster();

            player.AttackMonster(dark);
            player.AttackMonster(Light);
        }
        interface Monster
        {
            void HitFromPlayer(int damage);
        }

        class darkmonster : Monster
        {
            int hp = 100;

            public void HitFromPlayer(int damage)
            {
                hp = hp - damage;
                System.Console.WriteLine($"Monster : I'm Hit! My Hp is {hp}");
            }
        }

        class Lightmonster : Monster
        {
            int hp = 100;
            public void HitFromPlayer(int damage)
            {
                hp = hp - (damage / 2);
                System.Console.WriteLine($"LightMonster : I'm Hit! but half, my Hp is {hp}");
            }
        }

        class player
        {
            int AttackDamage = 15;
            public void AttackMonster(Monster monster)
            {
                System.Console.WriteLine("Player : I'm Attacking Monster!");
                monster.HitFromPlayer(AttackDamage);
            }
        }
    }
}
