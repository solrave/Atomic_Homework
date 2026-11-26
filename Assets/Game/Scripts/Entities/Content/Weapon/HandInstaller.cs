using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class HandInstaller : GameEntityInstaller
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
        
        public override void Install(IGameEntity entity)
        {
           _attackInstaller.Install(entity);

           entity.AddTrigger(_trigger);
           entity.AddDamage(new Variable<int>(_damage));
           
           entity.AddBehaviour(new HandAttackBehaviour(_hitDelay));
           
           entity.GetAttackCondition().Add(() => _cooldown.IsCompleted());
           
           entity.GetAttackAction().Add(_ => _cooldown.ResetTime());
           entity.GetAttackAction().Add(_ => _hitDelay.Start());
           
           entity.WhenTick(_cooldown.Tick);
           entity.WhenTick(_hitDelay.Tick);
        }
    }
}