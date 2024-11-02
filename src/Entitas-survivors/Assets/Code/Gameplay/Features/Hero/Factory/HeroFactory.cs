using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Infrastructure.Identifiers;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Hero.Factory
{
    public class HeroFactory : IHeroFactory
    {
        private const int HERO_HP = 100;
        private readonly IIdentifierService _identifier;

        public HeroFactory(IIdentifierService identifier)
        {
            _identifier = identifier;
        }

        public GameEntity CreateHero(Vector3 at)
        {
            return CreateEntity.Empty()
               .AddId(_identifier.Next())
              .AddWorldPosition(at)
              .AddDirection(Vector2.zero)
              .AddSpeed(2)
              .AddMaxHP(HERO_HP)
              .AddCurrentHP(HERO_HP)
              .AddViewPath("Gameplay/Hero/hero")
              .With(x => x.isHero = true)
              .With(x => x.isTurnedAlongDirection = true)
              .With(x => x.isMovementAvailable = true)
              ;
        }
    }
}