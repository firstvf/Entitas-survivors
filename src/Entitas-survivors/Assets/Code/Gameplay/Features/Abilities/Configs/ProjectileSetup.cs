using System;

namespace Assets.Code.Gameplay.Features.Abilities.Configs
{
    [Serializable]
    public class ProjectileSetup
    {
        public int ProjectileCount = 1;

        public float Speed;
        public int Pierce = 1;
        public float ContactRadius = 1;
        public float LifeTime;

        public float OrbitRadius;
    }
}