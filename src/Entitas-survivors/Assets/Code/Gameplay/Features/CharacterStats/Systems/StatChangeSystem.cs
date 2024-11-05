using Assets.Code.Common.EntityIndices;
using Code.Common.Entity;
using Entitas;

namespace Assets.Code.Gameplay.Features.CharacterStats.Systems
{
    public class StatChangeSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _statOwners;
        private readonly GameContext _game;

        public StatChangeSystem(GameContext game)
        {
            _game = game;
            _statOwners = game.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.Id,
                GameMatcher.BaseStats,
                GameMatcher.StatsModifiers
                ));
        }

        public void Execute()
        {
            foreach (var statOwner in _statOwners)
                foreach (Stats stat in statOwner.BaseStats.Keys)
                {
                    statOwner.StatsModifiers[stat] = 0;

                    foreach (var statChange in _game.TargetStatChanges(stat, statOwner.Id))
                    {
                        statOwner.StatsModifiers[stat] += statChange.EffectValue;
                    }
                }
        }
    }
}