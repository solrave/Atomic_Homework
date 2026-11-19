using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public static class HealthUseCase
    {
        public static bool IsAliveTarget(this IEntity entity) => entity != null && entity.HasAliveTag();
        public static bool CanHeal(this IEntity entity) => entity.GetCurrentHealth().Value < entity.GetMaxHealth().Value;
        
        public static void Heal(this IEntity entity, int points)
        {
            if (!entity.IsAliveTarget()) return;
            
            var currentHealth =  entity.GetCurrentHealth().Value;
            entity.GetCurrentHealth().Value = Mathf.Max(currentHealth, currentHealth + points);
        }   
    }
}