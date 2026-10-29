using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game
{
    public class BulletInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private Rigidbody _rigidbody;
        
        [SerializeField] 
        private TriggerEvents _trigger;
        
        [SerializeField, Min(0)] 
        private int _damage;
        
        [SerializeField]
        private Variable<float> _moveSpeed;
        
        [SerializeField]
        private DownTimer _lifeTime;
        
        public override void Install(IEntity entity)
        {
            entity.AddMoveableTag();
            entity.AddRigidbody(_rigidbody);
            entity.AddMoveSpeed(_moveSpeed);
            entity.AddDamage(new Variable<int>(_damage));
            entity.AddLifeTime(_lifeTime);
            entity.AddMoveTime(new Variable<float>(0f));
            entity.AddTrigger(_trigger);
            
            entity.AddMoveRequest(new Request<Vector3>());
            entity.AddMoveCondition(new AndExpression<Vector3>());
            entity.AddMoveAction(new CompositeAction<Vector3, float>());
            entity.AddMoveEvent(new Event<Vector3>());
            
            entity.WhenFixedTick(_ => entity.GetMoveRequest().Invoke(entity.GetRigidbody().rotation * Vector3.forward));
            entity.GetMoveAction().Add(entity.RigidbodyMoveStep);
            
            entity.AddBehaviour<MoveBehaviour>();
            entity.AddBehaviour<BulletCollisionBehaviour>();
            entity.AddBehaviour<BulletLifeBehaviour>();
        }
    }
}