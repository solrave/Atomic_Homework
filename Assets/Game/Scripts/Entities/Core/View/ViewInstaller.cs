using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class ViewInstaller : GameEntityInstaller
    {
        private static readonly int IsMoving = Animator.StringToHash("IsMoving");
        private static readonly int Death = Animator.StringToHash("Death");
        private static readonly int Attack = Animator.StringToHash("Attack");
        private static readonly int TakeDamage = Animator.StringToHash("TakeDamage");

        private readonly DisposableComposite _disposables = new();
        
        [SerializeField]
        private Animator _animator;
        
        public override void Install(IGameEntity entity)
        {
            entity.AddAnimator(_animator);
            
            entity.WhenTick(_ => _animator
                .SetBool(IsMoving, entity.IsMoving()))
                .AddTo(_disposables);
            
            entity.GetCurrentHealth().Subscribe(currentHealth => { if (currentHealth <= 0)
                    _animator.SetBool(Death, true);}).AddTo(_disposables);
            
            entity.GetWeapon().Value.WhenInit(()
                => entity.GetWeapon().Value.GetAttackEvent().Subscribe(()
                    => entity.GetAnimator().SetTrigger(Attack))).AddTo(_disposables);
            
            entity.GetTakeDamageEvent().Subscribe(_ 
                => _animator.SetTrigger(TakeDamage)).AddTo(_disposables);
        }

        public override void Uninstall(IGameEntity entity)
        {
            _disposables.Dispose();
        }
    }
}