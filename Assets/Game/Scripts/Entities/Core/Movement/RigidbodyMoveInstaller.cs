using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class RigidbodyMoveInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private float _moveSpeed;
        
        [SerializeField]
        private Const<float> _moveDuration;
        
        public override void Install(IEntity entity)
        {
            entity.AddMoveableTag();
            
            entity.AddMoveDuration(_moveDuration);
            entity.AddMoveTime(new Variable<float>(-_moveDuration));
            entity.AddMoveSpeed(new Variable<float>(_moveSpeed));
            
            entity.AddBehaviour<MoveBehaviour>();
            
            entity.AddMoveRequest(new Request<Vector3>());
            entity.AddMoveCondition(new AndExpression<Vector3>());
            entity.AddMoveAction(new CompositeAction<Vector3, float>());
            entity.AddMoveEvent(new Event<Vector3>());
            
            entity.GetMoveAction().Add(entity.RigidbodyMoveStep);
            entity.GetMoveCondition().Add(_ => entity.HasMoveableTag());
        }
    }
}