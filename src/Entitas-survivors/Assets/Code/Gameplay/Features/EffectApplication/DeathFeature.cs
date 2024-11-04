﻿using Assets.Code.Gameplay.Features.EffectApplication.Systems;
using Assets.Code.Infrastructure.Systems;

namespace Assets.Code.Gameplay.Features.EffectApplication
{
    public sealed class DeathFeature : Feature
    {
        public DeathFeature(ISystemFactory systems)
        {
            Add(systems.Create<MarkDeadSystem>());
            Add(systems.Create<UnapplyStatusesOfDeadTargetSystem>());
        }
    }
}