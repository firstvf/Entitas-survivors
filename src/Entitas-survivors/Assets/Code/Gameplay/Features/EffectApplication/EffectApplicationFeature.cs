using Assets.Code.Gameplay.Features.EffectApplication.Systems;
using Assets.Code.Infrastructure.Systems;

namespace Assets.Code.Gameplay.Features.EffectApplication
{
    public class EffectApplicationFeature : Feature
    {
        public EffectApplicationFeature(ISystemFactory systems)
        {
            Add(systems.Create<ApplyEffectsOnTargetsSystem>());            
            Add(systems.Create<ApplyStatusesOnTargetsSystem>());            
        }
    }
}