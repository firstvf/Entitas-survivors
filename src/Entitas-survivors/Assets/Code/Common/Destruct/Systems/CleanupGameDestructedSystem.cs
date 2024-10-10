using Entitas;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.Common.Destruct.Systems
{
    public class CleanupGameDestructedSystem : ICleanupSystem
    {
        private readonly IGroup<GameEntity> _entities;
        private List<GameEntity> _buffer = new(64);

        public CleanupGameDestructedSystem(GameContext game)
        {
            _entities = game.GetGroup(GameMatcher.Destructed);
        }

        public void Cleanup()
        {
            foreach (var entity in _entities.GetEntities(_buffer))
                entity.Destroy();
        }
    }
}