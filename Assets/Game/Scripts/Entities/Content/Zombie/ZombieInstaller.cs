using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class ZombieInstaller : SceneEntityInstaller
    {
        [SerializeField] 
        private RigidbodyInstaller _rigidBodyInstaller;
        
        [SerializeField] 
        private RigidbodyMoveInstaller _rigidBodyMoveInstaller;
        
        [SerializeField] 
        private RotationInstaller _rotationInstaller;

        [SerializeField]
        private HealthInstaller _healthInstaller;
        
        [SerializeField]
        private ViewInstaller _viewInstaller;

        [SerializeField]
        private float _attackDistance;
        
        [SerializeField]
        private SceneEntity _weapon;
        
        public override void Install(IEntity entity)
        {
            _rigidBodyInstaller.Install(entity);
            _rigidBodyMoveInstaller.Install(entity);
            _rotationInstaller.Install(entity);
            _healthInstaller.Install(entity);
            _viewInstaller.Install(entity);
            
            entity.AddWeapon(new Variable<IEntity>(_weapon));
           _weapon.WhenInstall(() => _weapon.GetAttackCondition().Add(entity, entity.IsAliveTarget));
            
            entity.AddTarget(new Variable<IEntity>());
            entity.AddAttackDistance(_attackDistance);
            
            entity.AddBehaviour<ZombieAIBehaviour>();
            entity.AddBehaviour<WeaponAttackAnimationBehaviour>();
            
            entity.GetMoveCondition().Add(_ => entity.HasAliveTag() && entity.HasMoveableTag());
            //entity.GetWeapon().Value.GetAttackCondition().Add(entity.IsAliveTarget);
        }
    }
}