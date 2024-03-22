using System;

namespace MyGame
{
    class Program
    {
        static int quantidadeDeInimgigos;
        static Enemy[] enemies;
        static void Main(string[] args)
        {
            quantidadeDeInimgigos = int.Parse(args[0]);
            enemies = new Enemy[quantidadeDeInimgigos];

            for (int i = 0; i < quantidadeDeInimgigos; i++)
            {
                string enemyName;
                Console.Write("Say the name of the enemy {0}: ", i + 1);
                enemyName = Console.ReadLine();
                enemies[i] = new Enemy(enemyName);
            }
            for (int i = 0; i < enemies.Length; i++)
            {
                Console.WriteLine("{0} {1} {2}", enemies[i].GetName() , enemies[i].GetHealth(),  enemies[i].GetShield());
            }
            bool willPowerup = true;
            while (willPowerup)
            {
                Console.Write("Want to PowerUp? (y/n)" );
                string answer = Console.ReadLine();
                if (answer == "n") willPowerup = false;
                if (answer == "y") PowerUpEnemy();
            }
            for (int i = 0; i < enemies.Length; i++)
            {
                Console.WriteLine("{0} {1} {2}", enemies[i].GetName() , enemies[i].GetHealth(),  enemies[i].GetShield());
            }
            
            for (int i = 0; i < enemies.Length; i++)
            {
                Console.WriteLine("Poweredup {0} times", enemies[i].GetHowManyTimesGotPowerUped());
            }
        }
        
        static private void PowerUpEnemy()
        {
            Console.Write("How much do you want to powerup health? ");
            int healthPowerUp = int.Parse(Console.ReadLine());
            Console.Write("How much do you want to powerup shield? ");
            int shieldPowerUp = int.Parse(Console.ReadLine());

            for (int i = 0; i < enemies.Length; i++)
            {
                Enemy.PowerUp whichPowerup;
                if (healthPowerUp != 0) if (shieldPowerUp == 0)
                {
                    whichPowerup = Enemy.PowerUp.health;
                    enemies[i].PickupPowerUp(whichPowerup, healthPowerUp);
                }
                if (shieldPowerUp != 0) if (healthPowerUp == 0)
                {
                    whichPowerup = Enemy.PowerUp.shield;
                    enemies[i].PickupPowerUp(whichPowerup, shieldPowerUp);
                }
                if (healthPowerUp != 0 && shieldPowerUp != 0)
                {
                    whichPowerup = Enemy.PowerUp.health & Enemy.PowerUp.shield;
                    enemies[i].PickupPowerUp(whichPowerup, shieldPowerUp);
                }
            }
        }
    }
}
