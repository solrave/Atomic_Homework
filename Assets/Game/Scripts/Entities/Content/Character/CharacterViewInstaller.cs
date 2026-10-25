using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class CharacterViewInstaller : SceneEntityInstaller
    {
        private static readonly int DEATH = Animator.StringToHash("Death");
        private Subscription<IEntity> _deathSubscription;
        
        [SerializeField]
        private Animator _animator;
        
        public override void Install(IEntity entity)
        {
            entity.AddAnimator(_animator);
            _deathSubscription = entity.GetDeathEvent().Subscribe(this.AnimateDeath);
        }

        private void AnimateDeath(IEntity obj)
        {
            _animator.SetBool(DEATH, true);
        }

        public override void Uninstall(IEntity entity)
        {
            base.Uninstall(entity);
            _deathSubscription.Dispose();
        }
    }
}