using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class LookBehaviour : IGameEntityFixedTick
    {
        public void FixedTick(IGameEntity entity, float deltaTime)
        {
            if (entity.HasAliveTag())
            {
                entity.RotateStep(deltaTime);
            }
        }
    }
}