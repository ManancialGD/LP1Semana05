using System;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        [Flags] public enum PowerUp{ health = 1 << 0, shield = 1 << 1}

        // Construtor
        public Enemy(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }
    
        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }

        public void PickupPowerUp(PowerUp powerUp, float f)
        {
            if (powerUp == PowerUp.health)
            {
                health += f;
                Console.WriteLine("Added {0} to {1} health", f, this.name);
            }
            else if (powerUp == PowerUp.shield)
            {
                shield += f;
                Console.WriteLine("Added {0} to {1} shield", f, this.name);
            }
            else if (powerUp == (PowerUp.health & PowerUp.shield))
            {
                Console.WriteLine("You added both health and shield Powerup");

                health += f;
                shield += f;
                if (health > 100f)
                {
                    health = 100f;
                    Console.WriteLine("As health of {0} was pass 100, it was set to 100", this.name);
                }
                if (shield > 100f)
                {
                    shield = 100f;
                    Console.WriteLine("As shield of {0} was pass 100, it was set to 100", this.name);
                }
            }
        }
        
        public string GetName()
        {
            return name;
        }

        public void Setname(string nameGet)
        {
            this.name = nameGet;
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }
    }
}
