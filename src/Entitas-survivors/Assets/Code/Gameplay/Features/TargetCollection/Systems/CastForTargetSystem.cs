using Code.Gameplay.Common.Physics;
using Entitas;
using System.Collections.Generic;
using System.Linq;

namespace Assets.Code.Gameplay.Features.TargetCollection.Systems
{
    public class CastForTargetSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _ready;
        private readonly IPhysicsService _physicsService;
        private readonly List<GameEntity> _buffer = new(64);

        public CastForTargetSystem(GameContext game, IPhysicsService physicsService)
        {
            _physicsService = physicsService;

            _ready = game.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.ReadyToCollectTargets,
                GameMatcher.TargetsBuffer,
                GameMatcher.WorldPosition,
                GameMatcher.Radius,
                GameMatcher.LayerMask
                ));
        }

        public void Execute()
        {
            foreach (var entity in _ready.GetEntities(_buffer))
            {
                entity.TargetsBuffer.AddRange(TargetsInRadius(entity));

                entity.isReadyToCollectTargets = false;
            }
        }

        private IEnumerable<int> TargetsInRadius(GameEntity entity)
        {
            return _physicsService
                .CircleCast
                (entity.WorldPosition, entity.Radius, entity.LayerMask)
                .Select(x => x.Id);
        }
    }
}