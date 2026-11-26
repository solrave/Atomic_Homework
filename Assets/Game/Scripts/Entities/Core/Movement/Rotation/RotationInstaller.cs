using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class RotationInstaller : GameEntityInstaller
    {
        [SerializeField]
        private float _rotationSpeed;
        
        public override void Install(IGameEntity entity)
        {
            entity.AddRotationSpeed(new Variable<float>(_rotationSpeed));
            entity.AddLookDirection(Vector3.zero);
            
            entity.AddBehaviour<LookBehaviour>();
        }
    }
}