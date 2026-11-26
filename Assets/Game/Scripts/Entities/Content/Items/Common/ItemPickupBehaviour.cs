using Atomic.Entities;

namespace Game
{
    public class ItemPickupBehaviour : IGameEntityInit, IGameEntityTick
    {
        private IGameEntity _item;
        
        public void Init(IGameEntity entity)
        {
            _item = entity;
        }

        public void Tick(IGameEntity entity, float deltaTime)
        {
            if (!_item.GetPickupRequest().Consume(out var player) 
                || !_item.GetPickupCondition().Invoke(player)) return;
            
            _item.GetPickupAction().Invoke(player);
            _item.GetPickupEvent().Invoke(player);
        }
    }
}