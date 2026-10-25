using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class MoveViewBehaviour : IEntityInit, IEntityDispose, IEntityTick
    {
        private const float MOVE_DURATION = 0.06f;
        private float _moveTime = -MOVE_DURATION;
        private static readonly int IsMoving = Animator.StringToHash("IsMoving");
        private Animator _animator;
        private IEvent<Vector3> _moveEvent;
        private Subscription<Vector3> _subscription;
        
        public void Init(IEntity entity)
        {
            _animator = entity.GetAnimator();
            _moveEvent = entity.GetMoveEvent();
            _subscription = _moveEvent.Subscribe(_ => _moveTime = Time.time);
        }

        public void Dispose(IEntity entity)
        {
            _subscription.Dispose();
        }

        public void Tick(IEntity entity, float deltaTime)
        {
            _animator.SetBool(IsMoving, Time.time - _moveTime <= MOVE_DURATION);
        }
    }
}