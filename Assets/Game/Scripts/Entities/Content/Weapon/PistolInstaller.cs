using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class PistolInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private int _ammo;
        
        [SerializeField, Min(0)]
        private float _spreadAngle;
        
        [SerializeField]
        private Transform _firePoint;
        
        [SerializeField]
        private SceneEntity _projectilePrefab;
        
        [SerializeField]
        private AttackInstaller _attackInstaller;
        
        [SerializeField]
        private Cooldown _cooldown;
        
        public override void Install(IEntity entity)
        {
           _attackInstaller.Install(entity);

           entity.AddAttackCooldown(_cooldown);
           entity.AddAmmo(new Variable<int>(_ammo));
           entity.AddSpreadAngle(_spreadAngle);
           
           entity.GetAttackAction().Add(() => entity.GetAmmo().Value--);
           entity.GetAttackAction().Add(entity.GetAttackCooldown().ResetTime);
           entity.GetAttackAction().Add(() => 
              SceneEntity.Create(_projectilePrefab, _firePoint.position, 
                  _firePoint.rotation.WithRandomSpread(entity.GetSpreadAngle())));
           
           entity.GetAttackCondition().Add(() => entity.GetAmmo().Value > 0);
           entity.GetAttackCondition().Add(entity.GetAttackCooldown().IsCompleted);
           
           entity.WhenTick(_cooldown.Tick);
        }
    }
}