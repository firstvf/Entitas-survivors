using Assets.Code.Gameplay.Features.DamageApplication.Systems;
using Assets.Code.Infrastructure.Systems;
using Entitas;

namespace Assets.Code.Gameplay.Features.DamageApplication
{
    public class DamageApplicationFeature : Feature
    {
        public DamageApplicationFeature(ISystemFactory systems)
        {
            Add(systems.Create<ApplyDamageOnTargetsSystem>());
        }
    }

}