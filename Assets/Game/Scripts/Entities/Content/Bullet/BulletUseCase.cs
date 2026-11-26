using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public static class BulletUseCase
    {
        public static void CheckHit(this IGameEntity entity, Vector3 direction, float deltaTime)
        {
            if (HitReceived(entity, direction, deltaTime, out IGameEntity target))
            {
                ApplyHit(entity, target);
            }
        }

        public static bool HitReceived(this IGameEntity entity, Vector3 direction, float deltaTime, out IGameEntity targetEntity)
        {
            var radius = entity.GetSphereCastRadius().Value;
            var layerMask = entity.GetLayerMask().Value;
            var origin = entity.GetRigidbody().position;
            var speed = entity.GetMoveSpeed().Value;
            targetEntity = null;

            if (!Physics.SphereCast(origin, radius, direction,
                    out RaycastHit hitInfo, speed * deltaTime, layerMask))
                return false;
            
            if (!hitInfo.collider.TryGetGameEntity(out var target))
                return false;

            if (!target.IsAliveTarget())
                return false;
            
            targetEntity = target;
            return true;
        }

        public static void ApplyHit(IGameEntity entity, IGameEntity targetEntity)
        {
            var damage = entity.GetDamage().Value;
            targetEntity.GetTakeDamageRequest().Invoke(damage);
            entity.DelMoveableTag();
            entity.GetLifeTime().Stop();
            entity.GetDespawnEvent().Invoke();
        }
    }
}