using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;
using Event = Atomic.Elements.Event;

namespace Game
{
    public class BulletInstaller : GameEntityInstaller
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
        
        public override void Install(IGameEntity bullet)
        {
            _rigidBodyInstaller.Install(bullet);
            _rigidBodyMoveInstaller.Install(bullet);
            
            bullet.AddLifeTime(_lifeTime);
            bullet.AddDamage(new Variable<int>(_damage));
            bullet.AddTrigger(_trigger);
            bullet.AddSphereCastRadius(_sphereCastRadius);
            bullet.AddLayerMask(_layerMask);
            bullet.AddDespawnEvent(new Event());
            
            bullet.GetMoveAction().Add(bullet.CheckHit);
            bullet.GetMoveAction().Add(bullet.RigidbodyMoveStep);
            bullet.WhenFixedTick(_ => bullet.GetMoveRequest().Invoke(bullet.GetRigidbody().rotation * Vector3.forward));
            
            bullet.AddBehaviour<BulletLifeTimeBehaviour>();
        }
    }
}