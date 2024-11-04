using Entitas;
using System.Collections.Generic;

namespace Assets.Code.Gameplay.Features.Statuses.Systems
{
    public class CleanupUnappliedStatuses : ICleanupSystem
    {
        private readonly IGroup<GameEntity> _group;
        private readonly List<GameEntity> _buffer = new(32);

        public CleanupUnappliedStatuses(GameContext game)
        {
            _group = game.GetGroup(
                GameMatcher.AllOf(
                    GameMatcher.Status,
                    GameMatcher.Unapplied
                    ));
        }

        public void Cleanup()
        {
            foreach (var status in _group.GetEntities(_buffer))
            {
                status.isDestructed = true;
            }
        }
    }
}