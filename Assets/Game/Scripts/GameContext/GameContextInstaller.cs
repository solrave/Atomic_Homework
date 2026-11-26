using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class GameContextInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private BulletPool _bulletPool;

        [SerializeField] 
        private GameEntity _player;

        public override void Install(IEntity entity)
        {
            entity.AddBulletPool(_bulletPool);
            entity.AddPlayer(_player);
        }
    }
}
