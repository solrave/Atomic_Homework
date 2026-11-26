using System.Collections.Generic;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class TargetSelectBehaviour : IGameEntityInit, IGameEntityDispose
    {
        private TriggerEvents _trigger;
        private List<GameEntity> _enemies;
        
        public void Init(IGameEntity entity)
        {
            _trigger = entity.GetTrigger();
            _trigger.OnEntered += this.OnTriggerEntered;
            _trigger.OnExited += this.OnTriggerExited;
            _enemies = entity.GetTriggerEnemies();
        }
        
        public void Dispose(IGameEntity entity)
        {
            _trigger.OnEntered -= this.OnTriggerEntered;
            _trigger.OnExited -= this.OnTriggerExited;
        }

        private void OnTriggerEntered(Collider target)
        {
            SelectTarget(target);
        }

        private void OnTriggerExited(Collider target)
        {
            ReleaseTarget(target);
        }
        
        private void SelectTarget(Collider target)
        {
            foreach (var enemy in _enemies)
            {
                enemy.SetTarget(target);
            }
        }

        private void ReleaseTarget(Collider target)
        {
            foreach (var enemy in _enemies)
            {
                enemy.ReleaseTarget(target);
            }
        }
    }
}