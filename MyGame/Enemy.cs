namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

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
