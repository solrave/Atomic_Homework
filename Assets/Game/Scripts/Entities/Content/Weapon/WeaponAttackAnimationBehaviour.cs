using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class WeaponAttackAnimationBehaviour : IEntityInit, IEntityDispose
    {
        private static readonly int Attack = Animator.StringToHash("Attack");
        private Subscription _sub;
        
        public void Init(IEntity entity)
        {
            _sub = entity.GetWeapon().Value.GetAttackEvent().Subscribe(() 
                => entity.GetAnimator().SetTrigger(Attack));
        }

        public void Dispose(IEntity entity)
        {
            _sub.Dispose();
        }
    }
}