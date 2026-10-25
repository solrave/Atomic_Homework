using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class MoveBehaviour : IEntityFixedTick, IEntityInit
    {
        private IRequest<Vector3> _request;
        private IExpression<Vector3, bool> _condition;
        private ICompositeAction<Vector3, float> _action;
        private IEvent<Vector3> _event;
        
        public void Init(IEntity entity)
        {
            _request = entity.GetMoveRequest();
            _condition = entity.GetMoveCondition();
            _action = entity.GetMoveAction();
            _event = entity.GetMoveEvent();
        }

        public void FixedTick(IEntity entity, float deltaTime)
        {
            if (_request.Consume(out var moveDirection) 
                && moveDirection != Vector3.zero 
                && _condition.Invoke(moveDirection))
            {
                _action.Invoke(moveDirection, deltaTime);
                _event.Invoke(moveDirection);
            }
        }
    }
}