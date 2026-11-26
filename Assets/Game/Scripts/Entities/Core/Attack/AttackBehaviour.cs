using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class AttackBehaviour : IGameEntityInit, IGameEntityTick
    {
        private IRequest<Vector3> _request;
        private IExpression<bool> _condition;
        private ICompositeAction<Vector3> _action;
        private IEvent _event;
        
        public void Init(IGameEntity entity)
        {
            _request = entity.GetAttackRequest();
            _condition = entity.GetAttackCondition();
            _action = entity.GetAttackAction();
            _event = entity.GetAttackEvent();
        }

        public void Tick(IGameEntity entity, float deltaTime)
        {
            if (!_request.Consume(out var direction) || !_condition.Invoke()) return;
            
            _action.Invoke(direction);
            _event.Invoke();
        }
    }
}