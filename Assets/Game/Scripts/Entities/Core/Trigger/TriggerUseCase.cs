using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public static class TriggerUseCase
    {
        public static void SetTarget(this SceneEntity entity, Collider target)
        {
            if (!target.TryGetEntity(out var player)) return;
               
            if (!player.HasAliveTag() || !player.HasPlayerTag()) return;
               
                entity.GetTarget().Value = player;
        }

        public static void ReleaseTarget(this SceneEntity entity, Collider target)
        {
            var currentTarget = entity.GetTarget().Value;

            if (!target.TryGetEntity(out var player) || !player.HasPlayerTag())
                return;
            
            if (currentTarget != null)
            {
                if (currentTarget.Equals(player))
                    entity.GetTarget().Value = null;
            }
        }
    }
}