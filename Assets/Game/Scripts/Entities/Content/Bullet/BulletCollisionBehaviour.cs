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
                Debug.Log("Bullet Trigger!");
            
            if (obj.TryGetComponent(out IEntity entity) && entity.HasDamageableTag() 
                                                        && entity.IsAliveTarget())
            {
                entity.GetTakeDamageRequest().Invoke(_damage.Value);
                Debug.Log("Bullet Collision!");
                SceneEntity.Destroy(_self);
            }
        }
    }
}