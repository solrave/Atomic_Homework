using UnityEngine;

namespace Game
{
    public static class PickupUseCase
    {
        public static void PickAmmo(this IGameEntity player, int amount) 
            => player.GetWeapon().Value.GetAmmo().Value += amount;
        
        public static void PickHealth(this IGameEntity player, int points)
        {
            if (!player.IsAliveTarget()) return;

            var maxHealth = player.GetMaxHealth().Value;
            var currentHealth =  player.GetCurrentHealth().Value;
            player.GetCurrentHealth().Value = Mathf.Min(currentHealth + points, maxHealth);
            Debug.Log($"CurrentHealth {player.GetCurrentHealth().Value}");
        }   
    }
}