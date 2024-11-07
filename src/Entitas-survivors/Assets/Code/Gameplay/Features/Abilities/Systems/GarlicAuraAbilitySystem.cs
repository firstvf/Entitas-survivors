using Assets.Code.Gameplay.Features.Armaments.Factory;
using Entitas;
using System.Collections.Generic;

namespace Assets.Code.Gameplay.Features.Abilities.Systems
{
    public class GarlicAuraAbilitySystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _abilities;
        private readonly IGroup<GameEntity> _heroes;
        private readonly IArmamentFactory _armamentFactory;

        private readonly List<GameEntity> _buffer = new(1);

        public GarlicAuraAbilitySystem(GameContext game, IArmamentFactory armamentFactory)
        {
            _armamentFactory = armamentFactory;

            _abilities = game.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.GarlicAuraAbility
                ).NoneOf(
                GameMatcher.Active
                ));

            _heroes = game.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.Hero,
                GameMatcher.Id
                ));
        }

        public void Execute()
        {

            foreach (var ability in _abilities.GetEntities(_buffer))
                foreach (var hero in _heroes)
                {
                    if (!ability.isActive)
                    {
                        _armamentFactory.CreateEffectAura(AbilityId.GarlicAura, hero.Id, level: 1);

                        ability.isActive = true;
                    }
                }
        }
    }
}