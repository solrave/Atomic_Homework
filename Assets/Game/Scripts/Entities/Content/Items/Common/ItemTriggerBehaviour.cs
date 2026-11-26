using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class ItemTriggerBehaviour : IGameEntityInit, IGameEntityDispose
    {
        private IGameEntity _item;
        private TriggerEvents _trigger;
        
        public void Init(IGameEntity item)
        {
            _item = item;
            _trigger = item.GetTrigger();
            _trigger.OnEntered += this.Pickup;
        }
        
        public void Dispose(IGameEntity item)
        {
            _trigger.OnEntered -= this.Pickup;
        }
        
        private void Pickup(Collider obj)
        {
            Debug.Log("Picup1");
            if (!obj.TryGetGameEntity(out var player) || !player.HasPlayerTag()) return;
            Debug.Log("Picup222222");

            _item.GetPickupRequest().Invoke(player);
        }
    }
}