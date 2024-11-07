using Assets.Code.Gameplay.Features.Effects;
using Assets.Code.Gameplay.Features.Statuses;
using Assets.Code.Infrastructure.View;
using System;
using System.Collections.Generic;

namespace Assets.Code.Gameplay.Features.Abilities.Configs
{
    [Serializable]
    public class AbilityLevel
    {
        public float Cooldown;
        public EntityBehaviour ViewPrefab;
        public List<EffectSetup> EffectSetups;
        public List<StatusSetup> StatusSetups;
        public ProjectileSetup ProjectileSetup;
        public AurasSetup AuraSetup;
    }
}           