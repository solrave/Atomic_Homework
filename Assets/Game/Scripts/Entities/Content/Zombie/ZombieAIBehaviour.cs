using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class ZombieAIBehaviour : IEntityInit, IEntityFixedTick
    {
        private IEntity _target;
        private float _attackDistance;
        
        public void Init(IEntity entity)
        {
            _attackDistance = entity.GetAttackDistance();
        }
        
        public void FixedTick(IEntity entity, float deltaTime)
        {
            _target = entity.GetTarget().Value;
            
            if (!_target.IsAliveTarget() || !entity.IsAliveTarget()) return;
            
            var direction = _target.GetRigidbody().position - entity.GetRigidbody().position;
            var flatDirection = new Vector3(direction.x, 0, direction.z);
            
            if (flatDirection.sqrMagnitude > _attackDistance * _attackDistance)
            {
                entity.GetMoveRequest().Invoke(flatDirection.normalized);
                entity.SetLookDirection(flatDirection.normalized);
            }
            else
            {
                entity.SetLookDirection(flatDirection.normalized);
                entity.GetWeapon().Value.GetAttackRequest().Invoke();
            }
        }
    }
}