using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class PistolInstaller : GameEntityInstaller
    {
        [SerializeField]
        private int _ammo;
        
        [SerializeField, Min(0)]
        private float _spreadAngle;
        
        [SerializeField]
        private Transform _firePoint;
        
        [SerializeField]
        private AttackInstaller _attackInstaller;
        
        [SerializeField]
        private Cooldown _cooldown;
        
        public override void Install(IGameEntity entity)
        {
           _attackInstaller.Install(entity);

           entity.AddAmmo(new ReactiveVariable<float>(_ammo));
           
           entity.GetAttackCondition().Add(() => entity.GetAmmo().Value > 0);
           entity.GetAttackCondition().Add(_cooldown.IsCompleted);
           
           entity.GetAttackAction().Add(_ => entity.GetAmmo().Value--);
           entity.GetAttackAction().Add(_ => _cooldown.ResetTime());
           entity.GetAttackAction().Add(look =>
           {
               var bullet = GameContext.Instance.GetBulletPool().Rent();
               bullet.GetRigidbody().position = _firePoint.position;
               bullet.GetRigidbody().rotation = Quaternion.LookRotation(look).WithRandomSpread(_spreadAngle);
           });
           
           entity.WhenTick(_cooldown.Tick);
        }
    }
}