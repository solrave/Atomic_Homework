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
        
        public override void Install(IGameEntity pistol)
        {
           _attackInstaller.Install(pistol);

           pistol.AddAmmo(new ReactiveVariable<float>(_ammo));
           
           pistol.GetAttackCondition().Add(() => pistol.GetAmmo().Value > 0);
           pistol.GetAttackCondition().Add(_cooldown.IsCompleted);
           
           pistol.GetAttackAction().Add(_ => pistol.GetAmmo().Value--);
           pistol.GetAttackAction().Add(_ => _cooldown.ResetTime());
           pistol.GetAttackAction().Add(look =>
           {
               var bullet = GameContext.Instance.GetBulletPool().Rent();
               bullet.GetRigidbody().position = _firePoint.position;
               bullet.GetRigidbody().rotation = Quaternion.LookRotation(look).WithRandomSpread(_spreadAngle);
           });
           
           pistol.WhenTick(_cooldown.Tick);
        }
    }
}