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
        
        public override void Install(IGameEntity entity)
        {
            entity.AddTrigger(_trigger);
            entity.AddVFX(_vfx);
            entity.AddSFX(_sfx);
            entity.AddAmount(_amount);
            
            entity.AddPickupRequest(new Request<IGameEntity>());
            entity.AddPickupCondition(new AndExpression<IGameEntity>());
            entity.AddPickupAction(new CompositeAction<IGameEntity>());
            entity.AddPickupEvent(new Event<IGameEntity>());
            
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
        
        public override void Uninstall(IGameEntity entity)
        {
            _disposables.Dispose();
        }
    }
}