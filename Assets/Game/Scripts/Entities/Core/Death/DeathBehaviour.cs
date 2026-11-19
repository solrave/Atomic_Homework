using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class DeathBehaviour : IEntityInit, IEntityDispose
    {
        private IEvent<IEntity> _deathEvent;
        private IReactiveVariable<int> _currentHealth;
        private Subscription<int> _subscription;
        private IEntity _entity;
        private Collider _collider;
        
        public void Init(IEntity entity)
        {
            _entity = entity;
            _deathEvent = entity.GetDeathEvent();
            _currentHealth = entity.GetCurrentHealth();
            _subscription = _currentHealth.Subscribe(this.CheckHealth);
            _collider = entity.GetHitCollider();
        }

        private void CheckHealth(int obj)
        {
            if (_currentHealth.Value <= 0)
            {
                _entity.DelAliveTag();
                _deathEvent.Invoke(_entity);
                _collider.enabled = false;
            }
        }

        public void Dispose(IEntity entity)
        {
            _subscription.Dispose();
        }
    }
}