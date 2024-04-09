using System;
 

namespace Task
{
    class Enemy : IndividualEntity
    {
        int level;
        bool isAlive = true;

         

        int health;
        int millidamange;
        int defence;
        int rangedDamage;
        
        public Enemy() { }
        public  Enemy( int health, int millidamange, int defence, int rangedDamage,int level)
        {
            this.level = level;
            SetHealth(health);
            SetDefence(defence);
            SetMeleeDamage(millidamange);
            SetRangedDamage(rangedDamage);


        }


    
        
        public void EnemyAttacked(Player player)
        {
            int rand = GenerateRandom(3);
            switch(rand)
            {
                case 1:
                    Console.WriteLine("Enemy Attacked By Mellee Damage");
                    EnemyMelleeAttacked(player.GetMeleeDamage());
                    break;

                case 2:
                    Console.WriteLine("Enemy Attacked By Ranged");
                    EnemyRangedAttacked(player.GetRangedDamage());
                    break;
                default :
                    Console.WriteLine("Enemy Goes Into Defence Mode");
                    EnemyDefence(defence);
                    break;

            }
        }
        public void EnemyMelleeAttacked(int dec)
        {
             
            health = health - dec;
             
             
            if(health < 0)
            {
                Console.WriteLine("Enemy Died !");
                isAlive = false;
            }
        }
        public void EnemyRangedAttacked(int dec)
        {
            health = health - dec;
            if (health < 0)
            {
                Console.WriteLine("Enemy Died !");
                isAlive = false;
            }
        }
        public void EnemyDefence(int dec)
        {
            health = health - GenerateRandom(dec);
            if (health < 0)
            {
                Console.WriteLine("Enemy Died !");
                isAlive = false;
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
        public void EnemyInfo()
        {
         
            Console.WriteLine($"Health  of Enemy      : {health}");
            

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
    }
}
