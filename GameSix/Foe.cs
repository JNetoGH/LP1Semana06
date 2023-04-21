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
        
        public void SetName(string newName) => name = newName.TrimEnd().TrimStart();
        public string GetName() => name;
        public float GetHealth() => health;
        public float GetShield() => shield;
        
    }
}