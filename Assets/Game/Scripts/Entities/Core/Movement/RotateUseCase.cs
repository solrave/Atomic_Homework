using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public static class RotateUseCase
    {
        public static void RotateStep(this IEntity entity, float deltaTime)
        {
            var rigidbody = entity.GetRigidbody();
            var lookDirection = entity.GetLookDirection().Value;
            var rotationSpeed = entity.GetRotationSpeed().Value;

            if (lookDirection != Vector3.zero)
            {
                var lookRotation = Quaternion.LookRotation(lookDirection);
                var nextRotation = Quaternion.RotateTowards
                    (rigidbody.rotation, lookRotation, rotationSpeed * deltaTime);
                rigidbody.MoveRotation(nextRotation);
            }
        }
    }
}