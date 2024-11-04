using Assets.Code.Gameplay.Features.Effects.Factory;
using Entitas;

namespace Assets.Code.Gameplay.Features.EffectApplication.Systems
{
    public partial class ApplyEffectsOnTargetsSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _entities;        
        private readonly IEffectFactory _effectFactory;

        public ApplyEffectsOnTargetsSystem(GameContext game, IEffectFactory effectFactory)
        {
            _effectFactory = effectFactory;
            _entities = game.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.TargetsBuffer,
                GameMatcher.EffectSetups
                ));
        }

        public void Execute()
        {
            foreach (var entity in _entities)
                foreach (var targetId in entity.TargetsBuffer)
                    foreach (var setup in entity.EffectSetups)
                    {
                        _effectFactory.CreateEffect(setup, ProducerId(entity), targetId);
                    }
        }

        private int ProducerId(GameEntity entity)
        {
            return entity.hasProducerId ? entity.ProducerId : entity.Id;
        }
    }
}