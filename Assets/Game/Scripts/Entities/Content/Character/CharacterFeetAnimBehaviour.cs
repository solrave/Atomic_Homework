using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class CharacterFeetAnimBehaviour : IGameEntityInit, IGameEntityTick, IGameEntityDispose
    {
        private static readonly int IsAiming = Animator.StringToHash("IsAiming");
        private static readonly int AimX = Animator.StringToHash("AimX");
        private static readonly int AimZ = Animator.StringToHash("AimZ");
        private const float AIM_DAMP_TIME = 0.052f;
        private Animator _animator;
        private Rigidbody _rigidbody;
        private IEvent<Vector3> _moveEvent;
        private Subscription<Vector3> _subscription;
        private Vector3 _local;

        public void Init(IGameEntity character)
        {
            _animator = character.GetAnimator();
            _rigidbody = character.GetRigidbody();
            _moveEvent = character.GetMoveEvent();
            _subscription = _moveEvent.Subscribe(this.OnMove);
            _animator.SetBool(IsAiming, true);
        }

        private void OnMove(Vector3 moveDirection)
        {
            _local = _rigidbody.transform.InverseTransformDirection(moveDirection);
        }

        public void Tick(IGameEntity character, float deltaTime)
        {
            _animator.SetFloat(AimX, _local.x, AIM_DAMP_TIME, deltaTime);
            _animator.SetFloat(AimZ, _local.z, AIM_DAMP_TIME, deltaTime);
        }
        
        public void Dispose(IGameEntity character)
        {
            _subscription.Dispose();
        }
    }
}