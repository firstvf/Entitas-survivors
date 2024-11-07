using Assets.Code.Gameplay.Features.Armaments.Systems;
using Assets.Code.Infrastructure.Systems;

namespace Assets.Code.Gameplay.Features.Armaments
{
    public sealed class ArmamentFeature : Feature
    {
        public ArmamentFeature(ISystemFactory systems)
        {
            Add(systems.Create<MarkProcessedOnTargetLimitExceededSystem>());
            Add(systems.Create<FollowProducerSystem>());
            //
            Add(systems.Create<FinalizeProcessedArmamentsSystem>());
        }
    }
}
