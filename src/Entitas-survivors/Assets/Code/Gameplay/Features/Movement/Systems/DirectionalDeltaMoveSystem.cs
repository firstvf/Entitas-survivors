using Entitas;

namespace Assets.Code.Gameplay.Features.Movement.Systems
{
    public class DirectionalDeltaMoveSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _movers;

        public DirectionalDeltaMoveSystem(GameContext context)
        {
            _movers = context.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.WorldPosition,
                GameMatcher.Speed));            
            
            11:30 // 03 first system
        }

        public void Execute()
        {

        }
    }
}