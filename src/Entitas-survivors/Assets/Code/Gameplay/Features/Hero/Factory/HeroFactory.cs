using Assets.Code.Gameplay.Features.CharacterStats;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Infrastructure.Identifiers;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Hero.Factory
{
    public class HeroFactory : IHeroFactory
    {
        private readonly IIdentifierService _identifier;

        public HeroFactory(IIdentifierService identifier)
        {
            _identifier = identifier;
        }

        public GameEntity CreateHero(Vector3 at)
        {
            Dictionary<Stats, float> baseStats = InitStats.EmptyStatDictionary()
                .With(x => x[Stats.Speed] = 2)
                .With(x => x[Stats.MaxHp] = 100);

            return CreateEntity.Empty()
              .AddId(_identifier.Next())
              .AddWorldPosition(at)
              .AddBaseStats(baseStats)
              .AddStatsModifiers(InitStats.EmptyStatDictionary())
              .AddDirection(Vector2.zero)
              .AddSpeed(baseStats[Stats.Speed])
              .AddMaxHP(baseStats[Stats.MaxHp])
              .AddCurrentHP(baseStats[Stats.MaxHp])
              .AddViewPath("Gameplay/Hero/hero")
              .With(x => x.isHero = true)
              .With(x => x.isTurnedAlongDirection = true)
              .With(x => x.isMovementAvailable = true)
              ;
        }
    }
}