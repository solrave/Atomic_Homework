using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public static class TriggerUseCase
    {
        public static void SetTarget(this IGameEntity entity, Collider target)
        {
            Debug.Log("Trigger1");
            
            if (!target.TryGetGameEntity(out var player))
                return;
            Debug.Log("Trigger222");

            if (!player.HasAliveTag() || !player.HasPlayerTag())
                return;
            Debug.Log("Trigger222");

            entity.GetTarget().Value = player;
        }

        public static void ReleaseTarget(this IGameEntity entity, Collider target)
        {
            if (!target.TryGetGameEntity(out var player) || !player.HasPlayerTag())
                return;

            var currentTarget = entity.GetTarget();

            if (currentTarget.Value != null && currentTarget.Value.Equals(player))
                currentTarget.Value = null;
        }
    }
}
