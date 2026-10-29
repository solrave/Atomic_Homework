using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public static class MoveUseCase
    {
        public static void RigidbodyMoveStep(this IEntity entity, Vector3 direction, float deltaTime)
        {
            entity.RigidbodyMoveStep(direction, entity.GetRigidbody(),
                entity.GetMoveSpeed().Value, deltaTime);
        }
        
        public static void RigidbodyMoveStep(this IEntity entity, Vector3 direction,
            Rigidbody body, float speed, float deltaTime)
        {
            body.MovePosition
                    (body.position + direction * (speed * deltaTime));
        }

        public static bool IsMoving(this IEntity entity)
        {
            return  Time.time - entity.GetMoveTime().Value <= entity.GetMoveDuration().Value;
        }
    }
}