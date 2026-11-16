using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class AttackBehaviour : IEntityInit, IEntityTick
    {
        private IRequest _request;
        private IExpression<bool> _condition;
        private ICompositeAction _action;
        private IEvent _event;
        
        public void Init(IEntity entity)
        {
            _request = entity.GetAttackRequest();
            _condition = entity.GetAttackCondition();
            _action = entity.GetAttackAction();
            _event = entity.GetAttackEvent();
        }

        public void Tick(IEntity entity, float deltaTime)
        {
            if (!_request.Consume() || !_condition.Invoke()) return;
            
            Debug.Log("Attack Invoked!");
            _action.Invoke();
            _event.Invoke();
        }
    }
}