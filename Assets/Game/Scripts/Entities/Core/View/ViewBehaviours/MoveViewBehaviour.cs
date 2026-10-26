using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class MoveViewBehaviour : IEntityInit, IEntityTick
    {
        private static readonly int IsMoving = Animator.StringToHash("IsMoving");
        private Animator _animator;
        private Subscription<Vector3> _subscription;
        
        public void Init(IEntity entity)
        {
            _animator = entity.GetAnimator();
        }

        public void Tick(IEntity entity, float deltaTime)
        {
            _animator.SetBool(IsMoving, entity.IsMoving());
        }
    }
}