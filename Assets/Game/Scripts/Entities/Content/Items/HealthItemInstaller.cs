using Atomic.Elements;
using Atomic.Entities;

namespace Game
{
    public class HealthItemInstaller : ItemInstaller
    {
        public override void Install(IGameEntity entity)
        {
            base.Install(entity);

            entity.GetPickupAction().Add(player => player.PickHealth(entity.GetAmount()));
            entity.GetPickupCondition().Add(player => player.CanHeal());
        }
    }
}
