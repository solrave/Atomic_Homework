using Atomic.Elements;
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

        public override void Install(IEntity gameContext)
        {
            gameContext.AddBulletPool(_bulletPool);
            gameContext.AddPlayer(_player);
            gameContext.AddScore(new ReactiveVariable<int>());
        }
    }
}
