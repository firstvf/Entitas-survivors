using Entitas;
using System.Collections.Generic;

namespace Assets.Code.Gameplay.Features.Effects.Systems
{
    public class CleanupProcessedEffects : ICleanupSystem
    {
        private readonly IGroup<GameEntity> _group;
        private readonly List<GameEntity> _buffer = new(32);

        public CleanupProcessedEffects(GameContext game)
        {
            _group = game.GetGroup(
                GameMatcher.AllOf(
                    GameMatcher.Effect,
                    GameMatcher.Processed
                    ));
        }

        public void Cleanup()
        {
            foreach (var entity in _group.GetEntities(_buffer))
            {
                entity.Destroy();
            }
        }
    }
}