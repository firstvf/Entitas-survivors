﻿using Assets.Code.Infrastructure.View.Factory;
using Entitas;
using System.Collections.Generic;

namespace Assets.Code.Infrastructure.View.Systems
{
    public class BindEntityViewFromPathSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _entities;
        private readonly IEntityViewFactory _entityViewFactory;
        private readonly List<GameEntity> _buffer = new(32);

        public BindEntityViewFromPathSystem(GameContext game, IEntityViewFactory entityViewFactory)
        {
            _entityViewFactory = entityViewFactory;
            _entities = game.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.ViewPath
                ).NoneOf(
                GameMatcher.View
                ));
        }

        public void Execute()
        {
            foreach (var entity in _entities.GetEntities(_buffer))
            {
                _entityViewFactory.CreateViewForEntity(entity);
            }
        }
    }
}