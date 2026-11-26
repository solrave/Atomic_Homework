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
        
        public override void Install(IGameEntity hand)
        {
           _attackInstaller.Install(hand);

           hand.AddTrigger(_trigger);
           hand.AddDamage(new Variable<int>(_damage));
           
           hand.AddBehaviour(new HandAttackBehaviour(_hitDelay));
           
           hand.GetAttackCondition().Add(() => _cooldown.IsCompleted());
           
           hand.GetAttackAction().Add(_ => _cooldown.ResetTime());
           hand.GetAttackAction().Add(_ => _hitDelay.Start());
           
           hand.WhenTick(_cooldown.Tick);
           hand.WhenTick(_hitDelay.Tick);
        }
    }
}