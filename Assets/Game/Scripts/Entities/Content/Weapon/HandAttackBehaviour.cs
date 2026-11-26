using Atomic.Elements;
using Atomic.Entities;

namespace Game
{
    public class HandAttackBehaviour : IGameEntityInit, IGameEntityDispose
    {
        private DownTimer _hitDelay;
        private TriggerEvents _handAttackRange;
        private IVariable<int> _damage;

        public HandAttackBehaviour(DownTimer hitDelay)
        {
            _hitDelay = hitDelay;
        }
        
        public void Init(IGameEntity hand)
        {
            _handAttackRange = hand.GetTrigger();
            _hitDelay.OnCompleted += this.ApplyHit;
            _damage = hand.GetDamage();
        }

        private void ApplyHit()
        {
            foreach (var target in _handAttackRange.CurrentColliders)
            {
                if (target.TryGetGameEntity(out var targetEntity)
                    && targetEntity.HasPlayerTag() && targetEntity.IsAliveTarget())
                {
                    targetEntity.GetTakeDamageRequest().Invoke(_damage.Value);
                }
            }
        }
        
        public void Dispose(IGameEntity hand)
        {
            _hitDelay.OnCompleted -= this.ApplyHit;
        }
    }
}