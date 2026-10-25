using System;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class MoveInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private Rigidbody _rigidbody;

        [SerializeField]
        private float _moveSpeed;
        
        [SerializeField]
        private float _rotationSpeed;
        
        public override void Install(IEntity entity)
        {
            entity.AddMoveableTag();
            
            entity.AddMoveRequest(new Request<Vector3>());
            entity.AddMoveCondition(new AndExpression<Vector3>());
            entity.AddMoveAction(new CompositeAction<Vector3, float>());
            entity.AddMoveEvent(new Event<Vector3>());
            
            entity.AddBehaviour<MoveBehaviour>();
            entity.AddBehaviour<LookBehaviour>();
            
            entity.GetMoveAction().Add(entity.MoveStep);
            entity.GetMoveCondition().Add(_ => entity.HasMoveableTag() && entity.HasAliveTag());
            
            entity.AddRigidbody(_rigidbody);
            entity.AddMoveSpeed(new Variable<float>(_moveSpeed));
            entity.AddRotationSpeed(new Variable<float>(_rotationSpeed));
            entity.AddLookDirection(Vector3.zero);
        }
    }
}