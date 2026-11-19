using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class HandAttackBehaviour : IEntityInit, IEntityDispose
    {
        private DownTimer _hitDelay;
        private TriggerEvents _trigger;
        private IVariable<int> _damage;
        
        public void Init(IEntity entity)
        {
            _hitDelay = entity.GetHitDelay();
            _trigger = entity.GetTrigger();
            _hitDelay.OnCompleted += this.ApplyHit;
            _damage = entity.GetDamage();
        }

        private void ApplyHit()
        {
            foreach (var target in _trigger.CurrentColliders)
            {
                if (target.TryGetEntity(out IEntity targetEntity) 
                    && targetEntity.HasPlayerTag() && targetEntity.IsAliveTarget())
                {
                    targetEntity.GetTakeDamageRequest().Invoke(_damage.Value);
                }
            }
        }
        
        public void Dispose(IEntity entity)
        {
            _hitDelay.OnCompleted -= this.ApplyHit;
        }
    }
}