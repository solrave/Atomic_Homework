using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public static class DamageUseCase
    {
        public static void TakeDamage(this IGameEntity target, float damage)
        {
            var currentHealth =  target.GetCurrentHealth().Value;
            target.GetCurrentHealth().Value = Mathf.Max(0, currentHealth - damage);
        }   
    }
}