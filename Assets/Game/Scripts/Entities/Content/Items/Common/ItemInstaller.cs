using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class ItemInstaller : GameEntityInstaller
    {
        [SerializeField] 
        private TriggerEvents _trigger;
        
        [Header("Amount")]
        [SerializeField] 
        private int _amount;
        
        [Header("Pickup Visual")]
        [SerializeField] 
        private ParticleSystem _vfx;

        [Header("Pickup Sound")]
        [SerializeField] 
        private AudioSource _sfx;
        
        private DisposableComposite _disposables = new();
        
        public override void Install(IGameEntity item)
        {
            item.AddTrigger(_trigger);
            item.AddVFX(_vfx);
            item.AddSFX(_sfx);
            item.AddAmount(_amount);
            
            item.AddPickupRequest(new Request<IGameEntity>());
            item.AddPickupCondition(new AndExpression<IGameEntity>());
            item.AddPickupAction(new CompositeAction<IGameEntity>());
            item.AddPickupEvent(new Event<IGameEntity>());
            
            item.GetPickupEvent().Subscribe(_ 
                => AudioSource.PlayClipAtPoint(item.GetSFX().clip, transform.position)).AddTo(_disposables);
            
            item.GetPickupEvent().Subscribe(_ 
                => { var vfx = Instantiate(item.GetVFX(),
                    new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), transform.rotation);
                vfx.Play();}).AddTo(_disposables);
            
            item.GetPickupEvent().Subscribe(_ 
                => {gameObject.GetComponent<Collider>().enabled = false; 
                SceneEntity.Destroy(item, 0.3f);}).AddTo(_disposables);
            
            item.AddBehaviour<ItemTriggerBehaviour>();
            item.AddBehaviour<ItemPickupBehaviour>();
        }
        
        public override void Uninstall(IGameEntity item)
        {
            _disposables.Dispose();
        }
    }
}