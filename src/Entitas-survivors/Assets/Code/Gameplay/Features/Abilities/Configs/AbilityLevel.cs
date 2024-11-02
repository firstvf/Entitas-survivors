using Assets.Code.Infrastructure.View;
using System;

namespace Assets.Code.Gameplay.Features.Abilities.Configs
{
    [Serializable]
    public class AbilityLevel
    {
        public float Cooldown;
        public EntityBehaviour ViewPrefab;
        public ProjectileSetup ProjectileSetup;
    }
}           