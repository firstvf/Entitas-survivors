﻿using Code.Gameplay.Common.Time;
using Entitas;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Movement.Systems
{
    public class DirectionalDeltaMoveSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _movers;
        private readonly ITimeService _time;

        public DirectionalDeltaMoveSystem(GameContext game, ITimeService timeService)
        {
            _time = timeService;
            _movers = game.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.WorldPosition,
                GameMatcher.Direction,
                GameMatcher.Speed,
                GameMatcher.MovementAvailable,
                GameMatcher.Moving));
        }

        public void Execute()
        {
            foreach (var mover in _movers)
                if (mover.isMoving)
                    mover.ReplaceWorldPosition((Vector2)mover.WorldPosition + _time.DeltaTime * mover.Speed * mover.Direction);
        }
    }
}