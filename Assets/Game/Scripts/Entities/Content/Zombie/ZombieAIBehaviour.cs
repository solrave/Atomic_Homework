using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class ZombieAIBehaviour : IGameEntityInit, IGameEntityFixedTick
    {
        private IGameEntity _target;
        private float _attackDistance;
        
        public void Init(IGameEntity zombie)
        {
            _attackDistance = zombie.GetAttackDistance();
        }
        
        public void FixedTick(IGameEntity zombie, float deltaTime)
        {
            _target = zombie.GetTarget().Value;
            
            if (!_target.IsAliveTarget() || !zombie.IsAliveTarget()) return;
            
            var direction = _target.GetRigidbody().position - zombie.GetRigidbody().position;
            var flatDirection = new Vector3(direction.x, 0, direction.z);
            
            if (flatDirection.sqrMagnitude > _attackDistance * _attackDistance)
            {
                zombie.GetMoveRequest().Invoke(flatDirection.normalized);
                zombie.SetLookDirection(flatDirection.normalized);
            }
            else
            {
                zombie.SetLookDirection(flatDirection.normalized);
                zombie.GetWeapon().Value.GetAttackRequest().Invoke(zombie.GetLookDirection().Value);
            }
        }
    }
}