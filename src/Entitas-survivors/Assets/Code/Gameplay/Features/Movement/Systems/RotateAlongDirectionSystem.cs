﻿using Entitas;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Movement.Systems
{
    public class RotateAlongDirectionSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _entities;

        public RotateAlongDirectionSystem(GameContext game)
        {
            _entities = game.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.Transform,
                GameMatcher.RotationAlignedAlongDirection,
                GameMatcher.Direction
                ));
        }

        public void Execute()
        {
            foreach (var entity in _entities)
            {
                if (entity.Direction.sqrMagnitude >= 1f)
                {
                    float angle = Mathf.Atan2(entity.Direction.y, entity.Direction.x) * Mathf.Rad2Deg;
                    entity.Transform.rotation = Quaternion.Euler(0, 0, angle);
                }
            }
        }
    }
}