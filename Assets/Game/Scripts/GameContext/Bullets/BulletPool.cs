using Atomic.Elements;
using Atomic.Entities;

namespace Game
{
    public class BulletPool : SceneEntityPool<GameEntity>
    {
        protected override void OnCreate(GameEntity entity)
        {
            base.OnCreate(entity);
            entity.GetDespawnEvent().Subscribe(() => Return(entity));
        }

        protected override void OnRent(GameEntity entity)
        {
            base.OnRent(entity);
            entity.AddMoveableTag();
            entity.GetLifeTime().Restart();
        }
    }
}
