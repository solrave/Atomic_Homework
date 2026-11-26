using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class ZombieInstaller : GameEntityInstaller
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
        private GameEntity _weapon;
        
        public override void Install(IGameEntity zombie)
        {
            zombie.AddEnemyTag();
            zombie.AddWeapon(new Variable<IGameEntity>(_weapon));
           _weapon.WhenInstall(() => _weapon.GetAttackCondition().Add(zombie, zombie.IsAliveTarget));
            
            _rigidBodyInstaller.Install(zombie);
            _rigidBodyMoveInstaller.Install(zombie);
            _rotationInstaller.Install(zombie);
            _healthInstaller.Install(zombie);
            _viewInstaller.Install(zombie);
            
            zombie.AddTarget(new Variable<IGameEntity>());
            zombie.AddAttackDistance(_attackDistance);
            
            zombie.AddBehaviour<ZombieAIBehaviour>();
            
            zombie.GetMoveAction().Add(zombie.RigidbodyMoveStep);
            zombie.GetMoveCondition().Add(_ => zombie.HasAliveTag() && zombie.HasMoveableTag());
        }
    }
}