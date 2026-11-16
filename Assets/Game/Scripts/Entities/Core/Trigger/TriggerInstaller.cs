using System.Collections.Generic;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class TriggerInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private List<SceneEntity> _enemies;

        [SerializeField]
        private TriggerEvents _trigger;
        
        public override void Install(IEntity entity)
        {
            entity.AddTrigger(_trigger);
            entity.AddTriggerEnemies(_enemies);
            entity.AddBehaviour<TargetSelectBehaviour>();
        }
    }
}