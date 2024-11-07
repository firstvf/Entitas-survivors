﻿using Assets.Code.Gameplay.Features.Abilities;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Armaments.Factory
{
    public interface IArmamentFactory
    {
        GameEntity CreateVegetableBolt(int level, Vector3 at);
        GameEntity CreateBouncingVegetableBolt(int level, Vector3 at);        
        GameEntity CreateOrbitingMushroom(int level, Vector3 at, float phase);
        GameEntity CreateEffectAura(AbilityId parentAbilityId, int producerId, int level);
    }
}