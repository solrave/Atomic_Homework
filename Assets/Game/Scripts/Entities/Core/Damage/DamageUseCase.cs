using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public static class DamageUseCase
    {
        public static void TakeDamage(this IEntity entity, int damage)
        {
            var currentHealth =  entity.GetCurrentHealth().Value;
            entity.GetCurrentHealth().Value = Mathf.Max(0, currentHealth - damage);
        }   
    }
}