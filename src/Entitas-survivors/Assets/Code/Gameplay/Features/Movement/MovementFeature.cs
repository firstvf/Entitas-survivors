using Assets.Code.Gameplay.Features.Movement.Systems;
using Code.Gameplay.Common.Time;

namespace Assets.Code.Gameplay.Features.Movement
{
    public class MovementFeature : Feature
    {
        public MovementFeature(GameContext game, ITimeService timeService)
        {
            Add(new DirectionalDeltaMoveSystem(game, timeService));
            Add(new TurnAlongDirectionSystem(game));
            Add(new UpdateTransformPositionSystem(game));
        }
    }
}