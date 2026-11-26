using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class CharacterInstaller : GameEntityInstaller
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
        private GameEntity _weapon;
        
        public override void Install(IGameEntity entity)
        {
           entity.AddPlayerTag();
           entity.AddWeapon(new Variable<IGameEntity>(_weapon));
           _weapon.WhenInstall(() => _weapon.GetAttackCondition().Add(entity, entity.IsAliveTarget));
           
           _rigidBodyInstaller.Install(entity);
           _rigidBodyMoveInstaller.Install(entity);
           _rotationInstaller.Install(entity);
           _healthInstaller.Install(entity);
           _viewInstaller.Install(entity);
           
           entity.AddBehaviour<CharacterFeetAnimBehaviour>();
           entity.GetMoveAction().Add(entity.RigidbodyMoveStep);
           entity.GetMoveCondition().Add(_ => entity.HasAliveTag());
        }
    }
}