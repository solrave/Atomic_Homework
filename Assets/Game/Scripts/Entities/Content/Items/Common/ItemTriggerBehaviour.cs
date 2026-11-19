using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class ItemTriggerBehaviour : IEntityInit, IEntityDispose
    {
        private IEntity _item;
        private TriggerEvents _trigger;
        
        public void Init(IEntity entity)
        {
            _item = entity;
            _trigger = entity.GetTrigger();
            _trigger.OnEntered += this.Pickup;
        }
        
        public void Dispose(IEntity entity)
        {
            _trigger.OnEntered -= this.Pickup;
        }
        
        private void Pickup(Collider obj)
        {
            if (!obj.TryGetEntity(out var player) || !player.HasPlayerTag()) return;

            _item.GetPickupRequest().Invoke(player);
        }
    }
}