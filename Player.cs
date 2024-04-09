using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.Remoting.Activation;


namespace Task
{
    class Player : IndividualEntity
    {
        
        int level;
        bool isAlive = true;
        int health ;
        int millidamange ;
        int defence ;
        int rangedDamage ;

       
        protected List<string> specialAbility = new List<string>();
        protected List<string> specialItems = new List<string>();
        public Player( ) 
        { 
             
        }
       public Player(int health, int millidamange, int rangedDamage, int defence , int level )
        {
            this.level = level;
            SetHealth(health);
            SetDefence(defence);
            SetMeleeDamage(millidamange);
            SetRangedDamage(rangedDamage);


        }



        public void SetHealth(int value)
        {
            if (level == 1)
            {
                health = value;
            }
            else if (level == 2)
                health = value * 2;
            else if (level == 3)
                health = value * 3;
            else if (level == 4)
                health = value * 4;
            else if (level == 5)
                health = value * 5;
        }

        public int GetHealth()
        {
            return health;
        }



        public int GetRangedDamage()
        {
            return rangedDamage;
        }



        public void SetRangedDamage(int value)
        {
            if (level == 1)
            {
                rangedDamage = value;
            }
            else if (level == 2)
                rangedDamage = value * 2;
            else if (level == 3)
                rangedDamage = value * 3;
            else if (level == 4)
                rangedDamage = value * 4;
            else if (level == 5)
                rangedDamage = value * 5;
        }

        public void SetDefence(int value)
        {
            if (level == 1)
            {
                defence = value;
            }
            else if (level == 2)
                defence = value * 2;
            else if (level == 3)
                defence = value * 3;
            else if (level == 4)
                defence = value * 4;
            else if (level == 5)
                defence = value * 5;
        }

        public int GetDefence()
        {
            return defence;
        }

        public void SetMeleeDamage(int value)
        {
            if (level == 1)
            {
                millidamange = value;
            }
            else if (level == 2)
                millidamange = value * 2;
            else if (level == 3)
                millidamange = value * 3;
            else if (level == 4)
                millidamange = value * 4;
            else if (level == 5)
                millidamange = value * 5;
        }

        public int GetMeleeDamage()
        {
            return millidamange;
        }
        public void PlayerNormalHeal()
        {
            if (health < 40)
            {
                health += GenerateRandom(10);
            }
            else
            {
                Console.WriteLine("Player Is Healthy ");
            }

        }
        /*public void PlayerMeleeAttack()
        {
            enemy.EnemyMelleeAttacked(MeleeDamage);
        }
        public void PlayerRangedDamage()
        {
            enemy.EnemyRangedAttacked(RangedDamage);
        }*/
        public void PlayerAttaking(Enemy enemy)
        {
            int rand = GenerateRandom(2);
            switch (rand)
            {
                case 1:
                    PlayerMileeAttacked(enemy.GetMeleeDamage());
                    break;
                case 2:
                    PlayerRangedAttacked(enemy.GetRangedDamage());
                    break;
                default:
                    PlayerDefence(enemy.GetDefence());
                    break;
            }
        }
        /*public void PlayerAttacking()
        {
            int rand =GenerateRandom(2);
            switch (rand)
            {
                case 1:
                    PlayerMeleeAttack();
                    break;
                default:
                    PlayerRangedDamage();
                    break;
            }
        }*/

        public void PlayerRangedAttacked(int dec)
        {
            int health -= dec ;
            if (health < 0)
            {
                isAlive = false;
                Console.WriteLine("Game Over ");

            }
        }
        public void PlayerDefence(int dec)
        {
            health -= dec + GenerateRandom(dec) % 10;
            if (health < 0)
            {
                isAlive = false;
                Console.WriteLine("Game Over ");

            }

        }
        public void PlayerMileeAttacked(int dec)
        {
            health -= dec;
            if (health < 0)
            {
                isAlive = false;
                Console.WriteLine("Player Defeated");
                //GameOver(isAlive);

            }
        }
        public int GenerateRandom(int high)
        {
            Random rnd = new Random();
            return rnd.Next(high);//returns random integers < 10

        }
        public bool IsAlive()
        {
           return isAlive;
        }
        public void SpecialAbility(string ability)
        {
            specialAbility.Add(ability);
        }
        public void SpecialItem(string item)
        {
             specialItems.Add(item);
        }

        public void PlayerInfo()
        { 
            Console.WriteLine($"Health  of Player      : {health}");
            foreach(var item in specialItems) Console.WriteLine(item);
            /*Console.WriteLine($"MeleeDamage   : {MeleeDamage}");
            Console.WriteLine($"RangedDamage  : {RangedDamage}");
            Console.WriteLine($"Defence       : {Defence}");*/
            
        }
    }  
}
