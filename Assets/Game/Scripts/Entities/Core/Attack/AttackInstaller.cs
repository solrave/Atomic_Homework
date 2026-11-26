using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;
using Event = Atomic.Elements.Event;

namespace Game
{
    public class AttackInstaller : GameEntityInstaller
    {
        public override void Install(IGameEntity entity)
        {
            entity.AddAttackRequest(new Request<Vector3>());
            entity.AddAttackCondition(new AndExpression());
            entity.AddAttackAction(new CompositeAction<Vector3>());
            entity.AddAttackEvent(new Event());
            entity.AddBehaviour<AttackBehaviour>();
        }
    }
}