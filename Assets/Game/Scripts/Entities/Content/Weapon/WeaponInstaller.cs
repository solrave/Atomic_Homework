using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class WeaponInstaller : SceneEntityInstaller
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
        private FireInstaller _fireInstaller;
        
        [SerializeField]
        private Cooldown _cooldown;
        
        public override void Install(IEntity entity)
        {
           _fireInstaller.Install(entity);

           entity.AddFireCooldown(_cooldown);
           entity.AddAmmo(new Variable<int>(_ammo));
           entity.AddSpreadAngle(_spreadAngle);
           
           entity.GetFireAction().Add(() => entity.GetAmmo().Value--);
           entity.GetFireAction().Add(entity.GetFireCooldown().ResetTime);
           entity.GetFireAction().Add(() => 
              SceneEntity.Create(_projectilePrefab, _firePoint.position, 
                  FireUseCase.WithRandomSpread(_firePoint.rotation, entity.GetSpreadAngle())));
           
           entity.GetFireCondition().Add(() => entity.GetAmmo().Value > 0);
           entity.GetFireCondition().Add(entity.GetFireCooldown().IsCompleted);
           
           entity.WhenTick(_cooldown.Tick);
        }
    }
}