using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class DeathBehaviour : IEntityInit
    {
        private readonly DisposableComposite _disposables = new();
        
        public void Init(IEntity entity)
        {
            entity.GetCurrentHealth().Subscribe(currentHealth =>
                {
                    if (currentHealth > 0) return;
                    entity.DelAliveTag();
                    entity.GetHitCollider().enabled = false;
                })
                .AddTo(_disposables);
        }
    }
}