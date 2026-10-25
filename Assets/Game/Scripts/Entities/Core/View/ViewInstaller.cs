using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class ViewInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private Animator _animator;
        
        public override void Install(IEntity entity)
        {
            entity.AddAnimator(_animator);
            entity.AddBehaviour<DeathViewBehaviour>();
            entity.AddBehaviour<MoveViewBehaviour>();
        }
    }
}