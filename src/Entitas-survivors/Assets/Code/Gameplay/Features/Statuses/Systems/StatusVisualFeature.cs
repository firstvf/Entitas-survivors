using Assets.Code.Gameplay.Features.Statuses.Systems.StatusVisuals;
using Assets.Code.Infrastructure.Systems;

namespace Assets.Code.Gameplay.Features.Statuses.Systems
{
    public sealed class StatusVisualFeature : Feature
    {
        public StatusVisualFeature(ISystemFactory systems)
        {
            Add(systems.Create<ApplyPoisonVisualsSystem>());
            Add(systems.Create<UnapplyPoisonVisualsSystem>());

            Add(systems.Create<ApplyFreezeVisualsSystem>());
            Add(systems.Create<UnapplyFreezeVisualsSystem>());
        }
    }
}