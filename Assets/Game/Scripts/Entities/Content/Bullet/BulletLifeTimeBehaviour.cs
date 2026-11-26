using Atomic.Elements;
using Atomic.Entities;

namespace Game
{
    public sealed class BulletLifeTimeBehaviour : IGameEntityInit, IGameEntityFixedTick, IGameEntityDispose
    {
        private IGameEntity _self;
        private ITimer _lifeTime;
        
        public void Init(IGameEntity bullet)
        {
            _self = bullet;
            _lifeTime = bullet.GetLifeTime();
            _lifeTime.OnCompleted += this.OnLifeEnded;
        }

        public void FixedTick(IGameEntity bullet, float deltaTime) => _lifeTime.Tick(deltaTime);

        private void OnLifeEnded() => _self.GetDespawnEvent().Invoke();

        public void Dispose(IGameEntity bullet) => _lifeTime.OnCompleted -= this.OnLifeEnded;
    }
}