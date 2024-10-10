using Assets.Code.Infrastructure.View.Registrar;
using Code.Common.Extensions;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Hero.Registrars
{
    public class HeroRegistrar : EntityComponentRegistrar
    {
        public float MaxHP = 100f;
        public float Speed = 2f;

        public override void RegisterComponents()
        {
            Entity
             .AddWorldPosition(transform.position)
             .AddDirection(Vector2.zero)
             .AddSpeed(Speed)
             .AddMaxHP(MaxHP)
             .AddCurrentHP(MaxHP)
             .With(x => x.isHero = true)
             .With(x => x.isTurnedAlongDirection = true)
             ;
        }

        public override void UnregisterComponents()
        {

        }
    }
}