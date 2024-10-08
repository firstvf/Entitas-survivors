﻿using Assets.Code.Gameplay.Features.DamageApplication.Systems;
using Assets.Code.Infrastructure.Systems;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.DamageApplication
{
    public class DamageApplicationFeature : Feature
    {
        public DamageApplicationFeature(ISystemFactory systems)
        {
            Add(systems.Create<ApplyDamageOnTargetsSystem>());
            Add(systems.Create<DestructOnZeroHPSystem>());
        }
    }
}