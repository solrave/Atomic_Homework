using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public static class MoveUseCase
    {
        public static void MoveStep(this IEntity entity, Vector3 direction, float deltaTime)
        {
            entity.MoveStep(direction, entity.GetRigidbody(),
                entity.GetMoveSpeed().Value, deltaTime);
        }
        
        public static void MoveStep(this IEntity entity, Vector3 direction,
            Rigidbody body, float speed, float deltaTime)
        {
            body.MovePosition
                    (body.position + direction * (speed * deltaTime));
        }
    }
}