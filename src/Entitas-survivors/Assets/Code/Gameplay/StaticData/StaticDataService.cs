using Assets.Code.Gameplay.Features.Abilities;
using Assets.Code.Gameplay.Features.Abilities.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Code.Gameplay.StaticData
{
    public class StaticDataService : IStaticDataService
    {
        private Dictionary<AbilityId, AbilityConfig> _abilityById;

        public void LoadAll()
        {
            LoadAbilities();
        }

        public AbilityConfig GetAbilityConfig(AbilityId id)
        {
            if (_abilityById.TryGetValue(id, out AbilityConfig config))
                return config;

            throw new Exception($"Ability config for {id} was not found");
        }

        public AbilityLevel GetAbilityLevel(AbilityId id, int level)
        {
            AbilityConfig config = GetAbilityConfig(id);

            if (level > config.Levels.Count)
                level = config.Levels.Count;

            return config.Levels[level - 1];
        }

        private void LoadAbilities()
        {
            _abilityById = Resources.LoadAll<AbilityConfig>("Configs/Abilities")
                .ToDictionary(x => x.AbilityId, x => x);
        }
    }
}