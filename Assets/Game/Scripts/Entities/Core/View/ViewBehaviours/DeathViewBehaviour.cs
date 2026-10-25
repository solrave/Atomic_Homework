using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class DeathViewBehaviour : IEntityInit, IEntityDispose
    {
        private Animator _animator;
        private static readonly int DEATH = Animator.StringToHash("Death");
        private Subscription<IEntity> _deathSubscription;
        
        public void Init(IEntity entity)
        {
            _animator = entity.GetAnimator();
            _deathSubscription = entity.GetDeathEvent().Subscribe(this.AnimateDeath);
        }
        
        private void AnimateDeath(IEntity obj)
        {
            _animator.SetBool(DEATH, true);
        }

        public void Dispose(IEntity entity)
        {
            _deathSubscription.Dispose();
        }
    }
}