using Assets.Code.Gameplay.Features.Cooldowns;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Abilities.Factory
{
    public class AbilityFactory : IAbilityFactory
    {
        private readonly IIdentifierService _identifier;
        private readonly IStaticDataService _staticDataService;

        public AbilityFactory(IIdentifierService identifier, IStaticDataService staticDataService)
        {
            _identifier = identifier;
            _staticDataService = staticDataService;
        }

        public GameEntity CreateVegetableBoltAbility(int level)
        {
            var abilityLevel = _staticDataService.GetAbilityLevel(AbilityId.VegetableBolt, level);

            return CreateEntity.Empty()
                .AddId(_identifier.Next())
                .AddAbilityId(AbilityId.VegetableBolt)
                .AddCooldown(abilityLevel.Cooldown)
                .With(x => x.isVegetableBoltAbility = true)
                .PutOnCooldown();
        }
    }
}