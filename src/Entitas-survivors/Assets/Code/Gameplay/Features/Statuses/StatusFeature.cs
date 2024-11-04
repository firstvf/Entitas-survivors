using Assets.Code.Gameplay.Features.Statuses.Systems;
using Assets.Code.Gameplay.Features.Statuses.Systems.StatusVisuals;
using Assets.Code.Infrastructure.Systems;

namespace Assets.Code.Gameplay.Features.Statuses
{
    public sealed class StatusFeature : Feature
    {
        public StatusFeature(ISystemFactory systems)
        {
            Add(systems.Create<StatusDurationSystem>());
            Add(systems.Create<PeriodicDamageStatusSystem>());

            Add(systems.Create<StatusVisualFeature>());
            //
            Add(systems.Create<CleanupUnappliedStatuses>());
        }
    }
}