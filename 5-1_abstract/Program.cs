using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_버츄얼
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Player = new Player();
            
            Zombie zombie = new Zombie();
            Ghoul ghoul = new Ghoul();

            zombie.AttackPlayer(Player);
            System.Console.WriteLine();

            ghoul.AttackPlayer(Player);
            System.Console.WriteLine();

        }
        //Player
        class Player
        {
            int hp = 100;
            public void HitFromMonster(int AttackValue)
            {
                hp = hp - AttackValue;
                System.Console.WriteLine($"Player : I'm Hit! my Hp is {hp}");
            }
        }
        //obstrack

        abstract class Darkmonster
        {
            int attackValue = 10;

            public abstract void AttackPlayer(Player Player);
        }
        class Zombie : Darkmonster
        {
            public override void AttackPlayer(Player Player)
            {
                base.AttackPlayer(Player);
                System.Console.WriteLine("Monster(Zombie) : Player Bleeding");
            }
        }
        class Ghoul : Darkmonster
        {
            public override void AttackPlayer(Player Player)
            {
                System.Console.WriteLine("Monster(Ghoul) : Player Curse!");
            }
        }
    }
}
