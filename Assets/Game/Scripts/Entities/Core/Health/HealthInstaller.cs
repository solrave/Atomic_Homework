using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class HealthInstaller : SceneEntityInstaller
    {
        [SerializeField] 
        private int _maxHealth;

        [SerializeField]
        private Collider _hitCollider;

        public override void Install(IEntity entity)
        {
            entity.AddDamageableTag();
            entity.AddAliveTag();
            entity.AddMaxHealth(new Const<int>(_maxHealth));
            entity.AddCurrentHealth(new ReactiveVariable<int>(_maxHealth));
            entity.AddHitCollider(_hitCollider);
            
            entity.AddBehaviour<TakeDamageBehaviour>();
            entity.AddBehaviour<DeathBehaviour>();
            
            entity.AddTakeDamageRequest(new Request<int>());
            entity.AddTakeDamageCondition(new AndExpression<int>());
            entity.AddTakeDamageAction(new CompositeAction<int>(entity.TakeDamage));
            entity.AddTakeDamageEvent(new Event<int>());
            
            entity.GetTakeDamageCondition().Add(_ => entity.HasDamageableTag());
            entity.GetTakeDamageCondition().Add(_ => entity.HasAliveTag());
            entity.GetTakeDamageCondition().Add(damage => damage > 0);
        }
    }
}