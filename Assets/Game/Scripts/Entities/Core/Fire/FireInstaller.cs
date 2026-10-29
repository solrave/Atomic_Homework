using Atomic.Elements;
using Atomic.Entities;

namespace Game
{
    public class FireInstaller : SceneEntityInstaller
    {
        public override void Install(IEntity entity)
        {
            entity.AddFireRequest(new Request());
            entity.AddFireCondition(new AndExpression());
            entity.AddFireAction(new CompositeAction());
            entity.AddFireEvent(new Event());
            entity.AddBehaviour<FireBehaviour>();
        }
    }
}