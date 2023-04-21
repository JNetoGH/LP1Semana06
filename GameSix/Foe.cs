using System;

namespace GameSix
{
    public class Foe
    {
        
        private string name;
        private float health;
        private float shield;

        public Foe(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield >= 0) return;
            float damageStillToInflict = -shield;
            shield = 0;
            health -= damageStillToInflict;
            if (health < 0) health = 0;
        }

        public void PickPowerUp(PowerUp powerUp, float amount)
        {
            switch (powerUp)
            {
                case PowerUp.Health: health = (health + amount > 100) ? 100 : health + amount; break;
                case PowerUp.Shield: shield = (shield + amount > 100) ? 100 : shield + amount; break;
            }
        }
        
        public override string ToString() => $"name: {name}, health: {health}, shield: {shield}";
        
        public void SetName(string newName) => name = newName.TrimEnd().TrimStart();
        public string GetName() => name;
        public float GetHealth() => health;
        public float GetShield() => shield;
        
    }
}