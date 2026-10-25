using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class TakeDamageBehaviour : IEntityInit, IEntityTick
    {
        private IRequest<int> _request;
        private IExpression<int, bool> _condition;
        private ICompositeAction<int> _action;
        private IEvent<int> _event;
        
        public void Init(IEntity entity)
        {
            _request = entity.GetTakeDamageRequest();
            _condition = entity.GetTakeDamageCondition();
            _action = entity.GetTakeDamageAction();
            _event = entity.GetTakeDamageEvent();
        }
        
        public void Tick(IEntity entity, float deltaTime)
        {
            if (_request.Consume(out int damage) && _condition.Invoke(damage))
            {
                _action.Invoke(damage);
                _event.Invoke(damage);
            }
        }
    }
}