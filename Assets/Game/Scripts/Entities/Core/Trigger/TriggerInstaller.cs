using System.Collections.Generic;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class TriggerInstaller : GameEntityInstaller
    {
        [SerializeField]
        private List<GameEntity> _enemies;

        [SerializeField]
        private TriggerEvents _trigger;
        
        public override void Install(IGameEntity entity)
        {
            entity.AddTrigger(_trigger);
            entity.AddTriggerEnemies(_enemies);
            entity.AddBehaviour<TargetSelectBehaviour>();
        }
    }
}