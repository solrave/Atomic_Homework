using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class HandInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private AttackInstaller _attackInstaller;
        
        [SerializeField] 
        private TriggerEvents _trigger;
        
        [SerializeField]
        private Cooldown _cooldown;

        [SerializeField] 
        private DownTimer _hitDelay;

        [SerializeField] 
        private int _damage;
        
        public override void Install(IEntity entity)
        {
           _attackInstaller.Install(entity);

           entity.AddTrigger(_trigger);
           entity.AddAttackCooldown(_cooldown);
           entity.AddHitDelay(_hitDelay);
           entity.AddDamage(new Variable<int>(_damage));
           
           entity.AddBehaviour<HandAttackBehaviour>();
            
           entity.GetAttackAction().Add(entity.GetAttackCooldown().ResetTime);
           entity.GetAttackAction().Add(entity.GetHitDelay().Start);
           entity.GetAttackCondition().Add(() => entity.GetAttackCooldown().IsCompleted());
            
           entity.WhenTick(_cooldown.Tick);
           entity.WhenTick(_hitDelay.Tick);
        }
    }
}