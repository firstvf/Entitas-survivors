using Code.Common.Extensions;
using Entitas;
using System;
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
                GameMatcher.Direction,
                GameMatcher.SpriteRenderer
                ));
        }

        public void Execute()
        {
            foreach (var hero in _movers)
            {
                TurnAlongDirection(hero);
            }
        }

        private void TurnAlongDirection(GameEntity mover)
        {
            mover.SpriteRenderer.transform
                .SetScaleX(Mathf.Abs(mover.SpriteRenderer.transform.localScale.x) * FaceDirection(mover));
        }

        private float FaceDirection(GameEntity mover)
        => mover.Direction.x <= 0 ? -1 : 1;
    }
}