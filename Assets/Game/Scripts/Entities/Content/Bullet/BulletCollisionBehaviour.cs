using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public sealed class BulletCollisionBehaviour : IEntityInit, IEntityDispose
    {
        private TriggerEvents _trigger;
        private IEntity _self;
        private IValue<int> _damage;
        
        public void Init(IEntity entity)
        {
            _trigger = entity.GetTrigger();
            _self = entity;
            _damage = entity.GetDamage();
            _trigger.OnEntered += this.OnTriggerEnter;
        }
        
        public void Dispose(IEntity entity)
        {
            _trigger.OnEntered -= this.OnTriggerEnter;
        }
        
        private void OnTriggerEnter(Collider obj)
        {
            if (obj.TryGetComponent(out IEntity entity) && entity.HasDamageableTag())
            {
                var health = entity.GetCurrentHealth();
                health.Value = Mathf.Max(0, health.Value - _damage.Value);
            }
        }
    }
}