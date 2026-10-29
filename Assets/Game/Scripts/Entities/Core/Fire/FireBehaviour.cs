using Atomic.Elements;
using Atomic.Entities;

namespace Game
{
    public class FireBehaviour : IEntityInit, IEntityTick
    {
        private IRequest _request;
        private IExpression<bool> _condition;
        private ICompositeAction _action;
        private IEvent _event;
        
        public void Init(IEntity entity)
        {
            _request = entity.GetFireRequest();
            _condition = entity.GetFireCondition();
            _action = entity.GetFireAction();
            _event = entity.GetFireEvent();
        }

        public void Tick(IEntity entity, float deltaTime)
        {
            if (!_request.Consume() || !_condition.Invoke()) return;
            
            _action.Invoke();
            _event.Invoke();
        }
    }
}