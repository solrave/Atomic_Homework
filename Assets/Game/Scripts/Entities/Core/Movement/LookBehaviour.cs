using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class LookBehaviour : IEntityFixedTick
    {
        public void FixedTick(IEntity entity, float deltaTime)
        {
            if (entity.HasAliveTag())
            {
                entity.RotateStep(deltaTime);
            }
        }
    }
}