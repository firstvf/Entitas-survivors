using Code.Common.Extensions;
using Entitas;

namespace Assets.Code.Gameplay.Features.CharacterStats.Systems
{
    public class ApplySpeedFromStatsSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _statOwners;

        public ApplySpeedFromStatsSystem(GameContext game)
        {
            _statOwners = game.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.StatsModifiers,
                GameMatcher.BaseStats,
                GameMatcher.Speed
                ));
        }

        public void Execute()
        {
            foreach (var statOwner in _statOwners)
            {
                statOwner.ReplaceSpeed(MoveSpeed(statOwner).ZeroIfNegative());
            }
        }

        private float MoveSpeed(GameEntity statOwner)
        {
            return statOwner.BaseStats[Stats.Speed] + statOwner.StatsModifiers[Stats.Speed];
        }
    }
}