using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class RigidbodyInstaller : GameEntityInstaller
    {
        [SerializeField]
        private Rigidbody _rigidbody;
        
        public override void Install(IGameEntity entity)
        {
            entity.AddRigidbody(_rigidbody);
        }
    }
}