using Assets.Code.Gameplay.Features.Movement.Systems;
using Assets.Code.Infrastructure.Systems;

namespace Assets.Code.Gameplay.Features.Movement
{
    public class MovementFeature : Feature
    {
        public MovementFeature(ISystemFactory systems)
        {
            Add(systems.Create<DirectionalDeltaMoveSystem>());
            Add(systems.Create<TurnAlongDirectionSystem>());
            Add(systems.Create<UpdateTransformPositionSystem>());            
        }
    }
}