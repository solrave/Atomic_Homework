using Atomic.Elements;
using Atomic.Entities;

namespace Game
{
    public class AmmoItemInstaller : ItemInstaller
    {
        public override void Install(IGameEntity entity)
        {
            base.Install(entity);

            entity.GetPickupAction().Add(player => player.PickAmmo(entity.GetAmount()));
            entity.GetPickupCondition().Add(player => player.GetWeapon().Value.HasAmmo());
        }
    }
}
