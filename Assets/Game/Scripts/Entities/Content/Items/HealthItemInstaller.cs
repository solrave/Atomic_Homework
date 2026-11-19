using Atomic.Elements;
using Atomic.Entities;

namespace Game
{
    public class HealthItemInstaller : ItemInstaller
    {
        private DisposableComposite _disposables = new();
        
        public override void Install(IEntity entity)
        {
            base.Install(entity);
            
            entity.GetPickupAction().Add(player => player.Heal(entity.GetAmount()));
            entity.GetPickupCondition().Add(player => player.CanHeal());
        }

        public override void Uninstall(IEntity entity)
        {
            _disposables.Dispose();
        }
    }
}