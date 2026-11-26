using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public static class BulletUseCase
    {
        public static void CheckHit(this IGameEntity bullet, Vector3 direction, float deltaTime)
        {
            if (HitReceived(bullet, direction, deltaTime, out IGameEntity target))
            {
                ApplyHit(bullet, target);
            }
        }

        public static bool HitReceived(this IGameEntity bullet, Vector3 direction, float deltaTime, out IGameEntity targetEntity)
        {
            var radius = bullet.GetSphereCastRadius().Value;
            var layerMask = bullet.GetLayerMask().Value;
            var origin = bullet.GetRigidbody().position;
            var speed = bullet.GetMoveSpeed().Value;
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

        public static void ApplyHit(IGameEntity bullet, IGameEntity targetEntity)
        {
            var damage = bullet.GetDamage().Value;
            targetEntity.GetTakeDamageRequest().Invoke(damage);
            bullet.DelMoveableTag();
            bullet.GetLifeTime().Stop();
            bullet.GetDespawnEvent().Invoke();
        }
    }
}