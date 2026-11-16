using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class RigidbodyInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private Rigidbody _rigidbody;
        
        public override void Install(IEntity entity)
        {
            entity.AddRigidbody(_rigidbody);
        }
    }
}