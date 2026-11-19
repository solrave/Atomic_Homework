using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class ItemInstaller : SceneEntityInstaller
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
        
        public override void Install(IEntity entity)
        {
            entity.AddTrigger(_trigger);
            entity.AddVFX(_vfx);
            entity.AddSFX(_sfx);
            entity.AddAmount(_amount);
            
            entity.AddPickupRequest(new Request<IEntity>());
            entity.AddPickupCondition(new AndExpression<IEntity>());
            entity.AddPickupAction(new CompositeAction<IEntity>());
            entity.AddPickupEvent(new Event<IEntity>());
            
            entity.GetPickupEvent().Subscribe(_ 
                => AudioSource.PlayClipAtPoint(entity.GetSFX().clip, transform.position)).AddTo(_disposables);
            
            entity.GetPickupEvent().Subscribe(_ 
                => { var vfx = Instantiate(entity.GetVFX(),
                    new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), transform.rotation);
                vfx.Play();}).AddTo(_disposables);
            
            entity.GetPickupEvent().Subscribe(_ 
                => {gameObject.GetComponent<Collider>().enabled = false; 
                SceneEntity.Destroy(entity, 0.3f);}).AddTo(_disposables);
            
            entity.AddBehaviour<ItemTriggerBehaviour>();
            entity.AddBehaviour<ItemPickupBehaviour>();
        }
        
        public override void Uninstall(IEntity entity)
        {
            _disposables.Dispose();
        }
    }
}