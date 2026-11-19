using Atomic.Elements;
using Atomic.Entities;

namespace Game
{
    public class AmmoItemInstaller : ItemInstaller
    {
        private DisposableComposite _disposables = new();
        
        public override void Install(IEntity entity)
        {
            base.Install(entity);
            
            entity.GetPickupAction().Add(player => player.PickAmmo(entity.GetAmount()));
            entity.GetPickupCondition().Add(player => player.GetWeapon().Value.HasAmmo());
        }

        public override void Uninstall(IEntity entity)
        {
            _disposables.Dispose();
        }
    }
}