using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class CharacterAimBehaviour : IEntityInit, IEntityTick, IEntityDispose
    {
        private static readonly int IsAiming = Animator.StringToHash("IsAiming");
        private static readonly int AimX = Animator.StringToHash("AimX");
        private static readonly int AimZ = Animator.StringToHash("AimZ");
        private const float AIM_DUMP_TIME = 0.052f;
        private Animator _animator;
        private Rigidbody _rigidbody;
        private IEvent<Vector3> _moveEvent;
        private Subscription<Vector3> _subscription;
        private Vector3 _local;

        public void Init(IEntity entity)
        {
            _animator = entity.GetAnimator();
            _rigidbody = entity.GetRigidbody();
            _moveEvent = entity.GetMoveEvent();
            _subscription = _moveEvent.Subscribe(this.OnMove);
            _animator.SetBool(IsAiming, true);
        }

        private void OnMove(Vector3 moveDirection)
        {
            _local = _rigidbody.transform.InverseTransformDirection(moveDirection);
        }

        public void Tick(IEntity entity, float deltaTime)
        {
            _animator.SetFloat(AimX, _local.x, AIM_DUMP_TIME, deltaTime);
            _animator.SetFloat(AimZ, _local.z, AIM_DUMP_TIME, deltaTime);
        }
        
        public void Dispose(IEntity entity)
        {
            _subscription.Dispose();
        }

    }
}