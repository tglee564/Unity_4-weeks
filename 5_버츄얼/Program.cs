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
            
            Darkmonster darkmonster = new Darkmonster();
            Zombie zombie = new Zombie();
            Ghoul ghoul = new Ghoul();

            darkmonster.AttackPlayer(Player);
            System.Console.WriteLine();

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
        //virtual

        class Darkmonster
        {
            int attackValue = 10;

            public virtual void AttackPlayer(Player Player)
            {
                System.Console.WriteLine("Monster: Player Attack");
                Player.HitFromMonster(attackValue);
            }
        }
        class Zombie : Darkmonster
        {
            public override void AttackPlayer(Player Player)
            {
                base.AttackPlayer(Player); //부모가 가지고 있는 메소드 실행
                System.Console.WriteLine("Monster(Zombie) : Player Bleeding"); //내 메소드 실행
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
