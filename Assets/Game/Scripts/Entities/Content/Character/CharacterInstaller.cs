using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class CharacterInstaller : SceneEntityInstaller
    {
        [SerializeField] 
        private MoveInstaller _moveInstaller;

        [SerializeField]
        private HealthInstaller _healthInstaller;

        [SerializeField]
        private ViewInstaller _viewInstaller;
        
        public override void Install(IEntity entity)
        {
           _moveInstaller.Install(entity);
           _healthInstaller.Install(entity);
           _viewInstaller.Install(entity);
            entity.AddBehaviour<CharacterFeetAnimBehaviour>();
        }
    }
}