using Assets.Code.Gameplay.Features.Armaments.Factory;
using Assets.Code.Gameplay.Features.Cooldowns;
using Code.Common.Extensions;
using Code.Gameplay.StaticData;
using Entitas;
using System.Collections.Generic;
using System.Linq;

namespace Assets.Code.Gameplay.Features.Abilities.Systems
{
    public class BouncingVegetableBoltAbilitySystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _abilities;
        private readonly IGroup<GameEntity> _heroes;
        private readonly IGroup<GameEntity> _enemies;

        private readonly IStaticDataService _staticDataService;
        private readonly IArmamentFactory _armamentFactory;
        private readonly List<GameEntity> _buffer = new(1);

        public BouncingVegetableBoltAbilitySystem(GameContext game, IStaticDataService staticDataService, IArmamentFactory armamentFactory)
        {
            _staticDataService = staticDataService;
            _armamentFactory = armamentFactory;
            _abilities = game.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.BouncingVegetableBoltAbility,
                GameMatcher.CooldownUp
                ));

            _heroes = game.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.Hero,
                GameMatcher.WorldPosition
                ));

            _enemies = game.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.Enemy,
                GameMatcher.WorldPosition
                ));
        }

        public void Execute()
        {
            foreach (var ability in _abilities.GetEntities(_buffer))
                foreach (var hero in _heroes)
                {
                    if (_enemies.count <= 0)
                        continue;

                    _armamentFactory
                        .CreateBouncingVegetableBolt(1, hero.WorldPosition)
                        .ReplaceDirection((FirsAvailableTarget().WorldPosition - hero.WorldPosition).normalized)
                        .With(x => x.isMoving = true);

                    ability.PutOnCooldown(_staticDataService.GetAbilityLevel(AbilityId.BouncingVegetableBolt, 1).Cooldown);
                }
        }

        private GameEntity FirsAvailableTarget()
        {
            return _enemies.AsEnumerable().First();
        }
    }
}