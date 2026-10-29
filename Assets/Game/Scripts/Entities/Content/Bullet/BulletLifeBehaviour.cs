using Atomic.Elements;
using Atomic.Entities;

namespace Game
{
    public sealed class BulletLifeBehaviour : IEntityInit, IEntityFixedTick, IEntityDispose
    {
        private IEntity _self;
        private ITimer _lifeTime;
        
        public void Init(IEntity entity)
        {
            _self = entity;
            _lifeTime = entity.GetLifeTime();
            _lifeTime.OnCompleted += this.OnLifeEnded;
            _lifeTime.Start();
        }

        public void FixedTick(IEntity entity, float deltaTime)
        {
            //if (!_lifeTime.IsCompleted())
                _lifeTime.Tick(deltaTime);
        }
        
        private void OnLifeEnded() => SceneEntity.Destroy(_self);

        public void Dispose(IEntity entity) => _lifeTime.OnCompleted -= this.OnLifeEnded;
    }
}