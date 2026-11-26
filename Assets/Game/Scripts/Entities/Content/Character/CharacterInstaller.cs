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
        
        public override void Install(IGameEntity character)
        {
           character.AddPlayerTag();
           character.AddWeapon(new Variable<IGameEntity>(_weapon));
           _weapon.WhenInstall(() => _weapon.GetAttackCondition().Add(character, character.IsAliveTarget));
           
           _rigidBodyInstaller.Install(character);
           _rigidBodyMoveInstaller.Install(character);
           _rotationInstaller.Install(character);
           _healthInstaller.Install(character);
           _viewInstaller.Install(character);
           
           character.AddBehaviour<CharacterFeetAnimBehaviour>();
           character.GetMoveAction().Add(character.RigidbodyMoveStep);
           character.GetMoveCondition().Add(_ => character.HasAliveTag());
        }
    }
}