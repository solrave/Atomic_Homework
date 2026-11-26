using Atomic.Elements;
using Atomic.Entities;

namespace Game
{
    public class HealthItemInstaller : ItemInstaller
    {
        public override void Install(IGameEntity health)
        {
            base.Install(health);

            health.GetPickupAction().Add(player => player.PickHealth(health.GetAmount()));
            health.GetPickupCondition().Add(player => player.CanHeal());
        }
    }
}
