using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public static class GameEntityExtensions
    {
        public static bool TryGetGameEntity(this Component component, out IGameEntity entity)
        {
            entity = null;

            if (!component.TryGetEntity(out var found))
                return false;

            entity = found is SceneEntityProxy proxy
                ? proxy.Source as IGameEntity
                : found as IGameEntity;

            return entity != null;
        }
    }
}
