using Assets.Code.Gameplay.Features.Abilities.Configs;
using Assets.Code.Gameplay.Features.Armaments.Factory;
using Assets.Code.Gameplay.Features.Cooldowns;
using Code.Common.Extensions;
using Code.Gameplay.StaticData;
using Entitas;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Abilities.Systems
{
    public class OrbitingMushroomAbilitySystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _abilities;
        private readonly IGroup<GameEntity> _heroes;

        private readonly IStaticDataService _staticDataService;
        private readonly IArmamentFactory _armamentFactory;
        private readonly List<GameEntity> _buffer = new(1);

        public OrbitingMushroomAbilitySystem(GameContext game, IStaticDataService staticDataService, IArmamentFactory armamentFactory)
        {
            _staticDataService = staticDataService;
            _armamentFactory = armamentFactory;
            _abilities = game.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.OrbitingMushroomAbility,
                GameMatcher.CooldownUp
                ));

            _heroes = game.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.Hero,
                GameMatcher.WorldPosition
                ));
        }

        public void Execute()
        {
            foreach (var ability in _abilities.GetEntities(_buffer))
                foreach (var hero in _heroes)
                {
                    AbilityLevel abilityLevel = _staticDataService.GetAbilityLevel(AbilityId.OrbitingMushroom, 1);

                    var projectileCount = abilityLevel.ProjectileSetup.ProjectileCount;

                    for (int i = 0; i < projectileCount; i++)
                    {
                        var phase = (2 * Mathf.PI * i) / projectileCount;

                        CreateProjectile(hero, phase, level: 1);
                    }

                    ability.PutOnCooldown(abilityLevel.Cooldown);
                }
        }

        private void CreateProjectile(GameEntity hero, float phase, int level)
        {
            _armamentFactory
                .CreateOrbitingMushroom(level, hero.WorldPosition + Vector3.up, phase)
                .AddProducerId(hero.Id)
                .AddOrbitCenterFollowTarget(hero.Id)
                .AddOrbitCenterPosition(hero.WorldPosition)
                .isMoving = true;
        }
    }
}