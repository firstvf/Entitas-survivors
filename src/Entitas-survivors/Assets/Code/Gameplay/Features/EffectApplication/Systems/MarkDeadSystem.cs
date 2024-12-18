﻿using Entitas;
using System.Collections.Generic;

namespace Assets.Code.Gameplay.Features.EffectApplication.Systems
{
    public class MarkDeadSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _entities;
        private readonly List<GameEntity> _buffer = new(128);

        public MarkDeadSystem(GameContext game)
        {
            _entities = game.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.CurrentHP,
                GameMatcher.MaxHP
                ).
                NoneOf(
                GameMatcher.Dead
                ));
        }

        public void Execute()
        {
            foreach (var entity in _entities.GetEntities(_buffer))
            {
                if (entity.CurrentHP <= 0)
                {
                    entity.isDead = true;
                    entity.isProcessingDeath = true;
                }
            }
        }
    }
}