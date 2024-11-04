﻿using UnityEngine;

namespace Assets.Code.Gameplay.Features.Armaments.Factory
{
    public interface IArmamentFactory
    {
        GameEntity CreateVegetableBolt(int level, Vector3 at);
        GameEntity CreateBouncingVegetableBolt(int level, Vector3 at);
    }
}