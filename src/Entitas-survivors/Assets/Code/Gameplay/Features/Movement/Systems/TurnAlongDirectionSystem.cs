using Code.Common.Extensions;
using Entitas;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Movement.Systems
{
    public class TurnAlongDirectionSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _movers;

        public TurnAlongDirectionSystem(GameContext game)
        {
            _movers = game.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.TurnedAlongDirection,
                GameMatcher.SpriteRenderer,
                GameMatcher.Direction
                ));
        }

        public void Execute()
        {
            foreach (var mover in _movers)
            {
                if (mover.Direction.x > 0 && mover.SpriteRenderer.transform.localScale.x != 1)
                    mover.SpriteRenderer.transform.SetScaleX(1);
                else if (mover.Direction.x < 0 && mover.SpriteRenderer.transform.localScale.x != -1)
                    mover.SpriteRenderer.transform.SetScaleX(-1);
            }
        }
    }
}