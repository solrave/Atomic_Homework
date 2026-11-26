using Atomic.Elements;
using Atomic.Entities;

namespace Game
{
    public sealed class BulletLifeTimeBehaviour : IGameEntityInit, IGameEntityFixedTick, IGameEntityDispose
    {
        private IGameEntity _self;
        private ITimer _lifeTime;
        
        public void Init(IGameEntity entity)
        {
            _self = entity;
            _lifeTime = entity.GetLifeTime();
            _lifeTime.OnCompleted += this.OnLifeEnded;
        }

        public void FixedTick(IGameEntity entity, float deltaTime) => _lifeTime.Tick(deltaTime);

        private void OnLifeEnded() => _self.GetDespawnEvent().Invoke();

        public void Dispose(IGameEntity entity) => _lifeTime.OnCompleted -= this.OnLifeEnded;
    }
}