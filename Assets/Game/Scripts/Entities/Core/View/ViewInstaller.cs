using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class ViewInstaller : SceneEntityInstaller
    {
        private static readonly int IsMoving = Animator.StringToHash("IsMoving");
        private static readonly int DEATH = Animator.StringToHash("Death");
        
        private readonly DisposableComposite _disposables = new();
        
        [SerializeField]
        private Animator _animator;
        
        public override void Install(IEntity entity)
        {
            entity.AddAnimator(_animator);
            
            entity.WhenTick(_ => _animator
                .SetBool(IsMoving, entity.IsMoving()))
                .AddTo(_disposables);
            
            entity.GetDeathEvent().Subscribe(_ => _animator
                .SetBool(DEATH, true))
                .AddTo(_disposables);
        }

        public override void Uninstall(IEntity entity)
        {
            _disposables.Dispose();
        }
    }
}