using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task
{
    class BattleField
    {
        static int level = 1;
        

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The BattleFied TO Safe Village\n");
            StartGame();

        }
        static void StartGame()
        {
            Player player;
            Enemy enemy;
            for(int i = 1; i <=6; i++) 
            {
                player = new Player(100, 15, 12, 10,i);
                Console.WriteLine("Choose");
                if (i == 6)
                {
                    enemy = new Enemy(100,15,20,18,i);
                }
                
                    for (int j = 1; j <= i; j++)
                    {
                        player = new Player(100, 15, 12, 10, i);
                        Console.WriteLine($"Ready to Fight with Enemy {j}");
                        Console.WriteLine($"Floor : {level}");
                    if(i!=6)
                    { enemy = new Enemy(70, 6, 7, 3, i); }
                     
                        do
                        {

                            Console.WriteLine("1.Attack");
                            Console.WriteLine("2.Heal");
                            int option = int.Parse(Console.ReadLine());
                            switch (option)
                            {
                                case 1:
                                    enemy.EnemyAttacked(player);
                                    player.PlayerAttaking(enemy);
                                    break;
                                default:
                                    player.PlayerNormalHeal();
                                    break;
                            }
                            enemy.EnemyInfo();

                            player.PlayerInfo();
                            if (!player.IsAlive())
                            {
                                Console.WriteLine("Player Defeated");
                                Console.ReadLine();
                                Environment.Exit(0);
                            }
                        } while (enemy.IsAlive());
                        if (player.IsAlive() == false)
                        {
                            Console.WriteLine("Player Defeated ");
                            Console.WriteLine("Player Defeated");
                            Console.ReadLine();
                            Environment.Exit(0);
                        }


                    }
                    level++;
                    switch (level)
                    {
                        case 1:
                            player.SpecialItem("Map");
                            break;
                        case 2:
                            player.SpecialItem(" Sword");
                            break;
                        case 3:
                            player.SpecialItem("Shield");
                            break;
                        case 4:
                            player.SpecialItem("Armour");
                            break;
                        case 5:
                            player.SpecialItem("Bow");
                            break;
                    }
                    player.PlayerInfo();
                 
            }
            
        }
         
    }
}
