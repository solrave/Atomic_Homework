using Atomic.Entities;

namespace Game
{
    public class ItemPickupBehaviour : IEntityInit, IEntityTick
    {
        private IEntity _item;
        
        public void Init(IEntity entity)
        {
            _item = entity;
        }

        public void Tick(IEntity entity, float deltaTime)
        {
            if (!_item.GetPickupRequest().Consume(out var player) 
                || !_item.GetPickupCondition().Invoke(player)) return;
            
            _item.GetPickupAction().Invoke(player);
            _item.GetPickupEvent().Invoke(player);
        }
    }
}