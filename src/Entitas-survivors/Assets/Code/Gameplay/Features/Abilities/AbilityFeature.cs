using Assets.Code.Gameplay.Features.Abilities.Systems;
using Assets.Code.Gameplay.Features.Cooldowns.Systems;
using Assets.Code.Infrastructure.Systems;
using Assets.Code.Infrastructure.View.Systems;

namespace Assets.Code.Gameplay.Features.Abilities
{
    public sealed class AbilityFeature : Feature
    {
        public AbilityFeature(ISystemFactory systems)
        {
            Add(systems.Create<CooldownSystem>());
            Add(systems.Create<VegetableBoltAbilitySystem>());
        }
    }
}