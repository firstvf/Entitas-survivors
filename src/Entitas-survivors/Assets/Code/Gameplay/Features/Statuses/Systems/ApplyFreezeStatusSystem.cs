using Assets.Code.Gameplay.Features.CharacterStats;
using Code.Common.Entity;
using Entitas;
using System.Collections.Generic;

namespace Assets.Code.Gameplay.Features.Statuses.Systems
{
    public class ApplyFreezeStatusSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _statuses;
        private readonly List<GameEntity> _buffer = new(32);

        public ApplyFreezeStatusSystem(GameContext game)
        {
            _statuses = game.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.Id,
                GameMatcher.Status,
                GameMatcher.Freeze,
                GameMatcher.ProducerId,
                GameMatcher.TargetId,
                GameMatcher.EffectValue)
                .NoneOf(
                GameMatcher.Affected
                ));
        }

        public void Execute()
        {
            foreach (var status in _statuses.GetEntities(_buffer))
            {
                CreateEntity.Empty()
                    .AddStatChange(Stats.Speed)
                    .AddTargetId(status.TargetId)
                    .AddProducerId(status.ProducerId)
                    .AddEffectValue(status.EffectValue)
                    .AddApplierStatusLink(status.Id)                    
                    ;

                status.isAffected = true;
            }
        }
    }
}