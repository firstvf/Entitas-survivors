using Assets.Code.Gameplay.Features.DamageApplication.Systems;
using Assets.Code.Infrastructure.Systems;

namespace Assets.Code.Gameplay.Features.DamageApplication
{
    public sealed class DeathFeature : Feature
    {
        public DeathFeature(ISystemFactory systems)
        {
            Add(systems.Create<MarkDeadSystem>());
        }
    }

}