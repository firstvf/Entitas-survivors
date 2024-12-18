﻿using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Abilities.Configs
{
    [CreateAssetMenu(menuName = "ECS Survivors/Abilities",fileName = "abilityConfig")]
    public class AbilityConfig :ScriptableObject
    {
        public AbilityId AbilityId;
        public List<AbilityLevel> Levels;
    }
}