using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class DeathBehaviour : IGameEntityInit
    {
        private readonly DisposableComposite _disposables = new();
        
        public void Init(IGameEntity entity)
        {
            entity.GetCurrentHealth().Subscribe(currentHealth =>
                {
                    if (currentHealth > 0) return;
                    entity.DelAliveTag();
                    entity.GetHitCollider().enabled = false;

                    if (entity.HasEnemyTag())
                        GameContext.Instance.GetScore().Value++;
                })
                .AddTo(_disposables);
        }
    }
}