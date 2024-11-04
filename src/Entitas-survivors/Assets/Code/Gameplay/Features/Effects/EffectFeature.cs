using Assets.Code.Gameplay.Features.Effects.Systems;
using Assets.Code.Infrastructure.Systems;

namespace Assets.Code.Gameplay.Features.Effects
{
    public sealed class EffectFeature : Feature
    {
        public EffectFeature(ISystemFactory systems)
        {
            Add(systems.Create<RemoveEffectsWithoutTargetsSystem>());

            Add(systems.Create<ProcessDamageEffectSystem>());
            Add(systems.Create<CleanupProcessedEffects>());
        }
    }
}