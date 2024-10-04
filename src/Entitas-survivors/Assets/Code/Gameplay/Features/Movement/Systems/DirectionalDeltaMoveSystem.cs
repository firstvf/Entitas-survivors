using Code.Gameplay.Common.Time;
using Entitas;

namespace Assets.Code.Gameplay.Features.Movement.Systems
{
    public class DirectionalDeltaMoveSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _movers;
        private readonly ITimeService _timeService;

        public DirectionalDeltaMoveSystem(GameContext context, ITimeService timeService)
        {
            _movers = context.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.WorldPosition,
                GameMatcher.Speed));
            _timeService = timeService;
        }

        public void Execute()
        {

        }
    }
}