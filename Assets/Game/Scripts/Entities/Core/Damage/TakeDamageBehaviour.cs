using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class TakeDamageBehaviour : IGameEntityInit, IGameEntityTick
    {
        private IRequest<float> _request;
        private IExpression<float, bool> _condition;
        private ICompositeAction<float> _action;
        private IEvent<float> _event;
        
        public void Init(IGameEntity entity)
        {
            _request = entity.GetTakeDamageRequest();
            _condition = entity.GetTakeDamageCondition();
            _action = entity.GetTakeDamageAction();
            _event = entity.GetTakeDamageEvent();
        }
        
        public void Tick(IGameEntity entity, float deltaTime)
        {
            if (_request.Consume(out float damage) && _condition.Invoke(damage))
            {
                _action.Invoke(damage);
                _event.Invoke(damage);
            }
        }
    }
}