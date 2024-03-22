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
        }
    }
}
