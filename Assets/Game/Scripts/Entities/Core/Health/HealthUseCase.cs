using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public static class HealthUseCase
    {
        public static bool IsAliveTarget(this IGameEntity entity) => entity != null && entity.HasAliveTag();
        public static bool CanHeal(this IGameEntity entity) => entity.GetCurrentHealth().Value < entity.GetMaxHealth().Value;
    }
}