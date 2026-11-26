using Atomic.Elements;
using Atomic.Entities;

namespace Game
{
    public class AmmoItemInstaller : ItemInstaller
    {
        public override void Install(IGameEntity ammo)
        {
            base.Install(ammo);

            ammo.GetPickupAction().Add(player => player.PickAmmo(ammo.GetAmount()));
            ammo.GetPickupCondition().Add(player => player.GetWeapon().Value.HasAmmo());
        }
    }
}
