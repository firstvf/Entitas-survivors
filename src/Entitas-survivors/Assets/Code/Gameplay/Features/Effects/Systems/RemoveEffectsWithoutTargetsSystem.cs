using Entitas;
using System.Collections.Generic;

namespace Assets.Code.Gameplay.Features.Effects.Systems
{
    public class RemoveEffectsWithoutTargetsSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _effects;
        private readonly List<GameEntity> _buffer = new(32);

        public RemoveEffectsWithoutTargetsSystem(GameContext game)
        {
            _effects = game.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.Effect,
                GameMatcher.TargetId
                ));
        }

        public void Execute()
        {
            foreach (var effect in _effects.GetEntities(_buffer))
            {
                var target = effect.Target();

                if (target == null)
                    effect.Destroy();
            }
        }
    }
}