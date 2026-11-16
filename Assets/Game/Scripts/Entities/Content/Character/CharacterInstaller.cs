using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class CharacterInstaller : SceneEntityInstaller
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
        private SceneEntity _weapon;
        
        public override void Install(IEntity entity)
        {
           entity.AddPlayerTag();
           
           _rigidBodyInstaller.Install(entity);
           _rigidBodyMoveInstaller.Install(entity);
           _rotationInstaller.Install(entity);
           _healthInstaller.Install(entity);
           _viewInstaller.Install(entity);
           
           entity.AddWeapon(new Variable<IEntity>(_weapon));
           _weapon.WhenInstall(() => _weapon.GetAttackCondition().Add(entity, entity.IsAliveTarget));
           entity.AddBehaviour<CharacterFeetAnimBehaviour>();
           entity.AddBehaviour<WeaponAttackAnimationBehaviour>();
           entity.GetMoveCondition().Add(_ => entity.HasAliveTag());
        }
    }
}