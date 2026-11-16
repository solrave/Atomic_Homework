using Atomic.Entities;

namespace Game
{
    public static class HealthUseCase
    {
        public static bool IsAliveTarget(this IEntity entity) => entity != null && entity.HasAliveTag();
    }
}