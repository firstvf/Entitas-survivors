using Assets.Code.Gameplay.Features.Statuses.Applier;
using Entitas;

namespace Assets.Code.Gameplay.Features.EffectApplication.Systems
{
    public partial class ApplyStatusesOnTargetsSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _entities;
        private readonly IStatusApplier _statusApplier;

        public ApplyStatusesOnTargetsSystem(GameContext game,IStatusApplier statusApplier)
        {
            _statusApplier = statusApplier;
            _entities = game.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.TargetsBuffer,
                GameMatcher.StatusSetups
                ));
        }

        public void Execute()
        {
            foreach (var entity in _entities)
                foreach (var targetId in entity.TargetsBuffer)
                    foreach (var setup in entity.StatusSetups)
                    {                        
                        _statusApplier.ApplyStatus(setup, ProducerId(entity), targetId);
                    }
        }

        private int ProducerId(GameEntity entity)
        {
            return entity.hasProducerId ? entity.ProducerId : entity.Id;
        }
    }
}