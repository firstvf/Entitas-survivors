using Assets.Code.Gameplay.Features.Effects;
using Assets.Code.Gameplay.Features.Effects.Factory;
using Code.Gameplay.Common.Time;
using Entitas;

namespace Assets.Code.Gameplay.Features.Statuses.Systems
{
    public class PeriodicDamageStatusSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _statuses;
        private readonly ITimeService _timeService;
        private readonly IEffectFactory _effectFactory;

        public PeriodicDamageStatusSystem(GameContext game, ITimeService timeService, IEffectFactory effectFactory)
        {
            _timeService = timeService;
            _effectFactory = effectFactory;
            _statuses = game.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.Status,
                GameMatcher.Period,
                GameMatcher.TimeSinceLastTick,
                GameMatcher.EffectValue,
                GameMatcher.ProducerId,
                GameMatcher.TargetId
                ));
        }

        public void Execute()
        {
            foreach (var status in _statuses)
            {
                if (status.TimeSinceLastTick >= 0)
                    status.ReplaceTimeSinceLastTick(status.TimeSinceLastTick - _timeService.DeltaTime);
                else
                {
                    status.ReplaceTimeSinceLastTick(status.Period);

                    _effectFactory.CreateEffect(new EffectSetup { EffectTypeId = EffectTypeId.Damage, Value = status.EffectValue },
                     producerId: status.ProducerId,
                     targetId: status.TargetId);
                }
            }
        }
    }
}