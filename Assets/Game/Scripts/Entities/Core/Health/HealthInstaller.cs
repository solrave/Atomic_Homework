using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class HealthInstaller : GameEntityInstaller
    {
        [SerializeField] 
        private int _maxHealth;

        [SerializeField]
        private Collider _hitCollider;

        public override void Install(IGameEntity entity)
        {
            entity.AddDamageableTag();
            entity.AddAliveTag();
            entity.AddMaxHealth(new Const<float>(_maxHealth));
            entity.AddCurrentHealth(new ReactiveVariable<float>(_maxHealth));
            entity.AddHitCollider(_hitCollider);
            
            entity.AddBehaviour<TakeDamageBehaviour>();
            entity.AddBehaviour<DeathBehaviour>();
            
            entity.AddTakeDamageRequest(new Request<float>());
            entity.AddTakeDamageCondition(new AndExpression<float>());
            entity.AddTakeDamageAction(new CompositeAction<float>(entity.TakeDamage));
            entity.AddTakeDamageEvent(new Event<float>());
            
            entity.GetTakeDamageCondition().Add(_ => entity.HasDamageableTag());
            entity.GetTakeDamageCondition().Add(_ => entity.HasAliveTag());
            entity.GetTakeDamageCondition().Add(damage => damage > 0);
        }
    }
}