using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public static class BulletUseCase
    {
        public static void CheckHit(this IEntity entity, Vector3 direction, float deltaTime)
        {
            if (HitReceived(entity, direction, deltaTime, out IEntity target))
            {
                ApplyHit(entity, target);
            }
        }

        public static bool HitReceived(this IEntity entity, Vector3 direction, float deltaTime, out IEntity targetEntity)
        {
            var radius = entity.GetSphereCastRadius().Value;
            var layerMask = entity.GetLayerMask().Value;
            var origin = entity.GetRigidbody().position;
            var speed = entity.GetMoveSpeed().Value;
            targetEntity = null;

            if (!Physics.SphereCast(origin, radius, direction,
                    out RaycastHit hitInfo, speed * deltaTime, layerMask))
                return false;
            
            if (!hitInfo.collider.TryGetEntity(out var target))
                return false;

            if (!target.IsAliveTarget())
                return false;
            
            targetEntity = target;
            return true;
        }

        public static void ApplyHit(IEntity entity, IEntity targetEntity)
        {
            var damage = entity.GetDamage().Value;
            targetEntity.GetTakeDamageRequest().Invoke(damage);
            entity.DelMoveableTag();
            SceneEntity.Destroy(entity);
        }
    }
}