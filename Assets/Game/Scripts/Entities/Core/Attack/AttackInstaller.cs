using Atomic.Elements;
using Atomic.Entities;

namespace Game
{
    public class AttackInstaller : SceneEntityInstaller
    {
        public override void Install(IEntity entity)
        {
            entity.AddAttackRequest(new Request());
            entity.AddAttackCondition(new AndExpression());
            entity.AddAttackAction(new CompositeAction());
            entity.AddAttackEvent(new Event());
            entity.AddBehaviour<AttackBehaviour>();
        }
    }
}