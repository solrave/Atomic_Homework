using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class BulletInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private RigidbodyInstaller _rigidBodyInstaller;
        
        [SerializeField] 
        private RigidbodyMoveInstaller _rigidBodyMoveInstaller;
        
        [SerializeField] 
        private TriggerEvents _trigger;
        
        [Header("Damage")] 
        
        [SerializeField, Min(0)] 
        private int _damage;
        
        [Header("SphereCast")] 
        
        [SerializeField]
        private float _sphereCastRadius;

        [SerializeField]
        private LayerMask _layerMask;
        
        [SerializeField]
        private DownTimer _lifeTime;
        
        public override void Install(IEntity entity)
        {
            _rigidBodyInstaller.Install(entity);
            _rigidBodyMoveInstaller.Install(entity);
            
            entity.AddLifeTime(_lifeTime);
            entity.AddDamage(new Variable<int>(_damage));
            entity.AddTrigger(_trigger);
            entity.AddSphereCastRadius(_sphereCastRadius);
            entity.AddLayerMask(_layerMask);
            
            entity.GetMoveAction().Add(entity.CheckHit);
            entity.GetMoveAction().Add(entity.RigidbodyMoveStep);
            entity.WhenFixedTick(_ => entity.GetMoveRequest().Invoke(entity.GetRigidbody().rotation * Vector3.forward));
            
            entity.AddBehaviour<BulletLifeTimeBehaviour>();
        }
    }
}