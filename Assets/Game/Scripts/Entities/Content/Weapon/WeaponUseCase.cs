using Atomic.Entities;

namespace Game
{
    public static class WeaponUseCase
    {
        public static void PickAmmo(this IEntity entity, int amount) 
            => entity.GetWeapon().Value.GetAmmo().Value += amount;
    }
}