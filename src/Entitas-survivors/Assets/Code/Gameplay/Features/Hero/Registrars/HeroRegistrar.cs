using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Hero.Behaviours;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Hero.Registrars
{
    public class HeroRegistrar : MonoBehaviour
    {
        public float Speed = 2f;

        private GameEntity _entity;

        private void Awake()
        {
            var heroAnimator = GetComponent<HeroAnimator>();

            _entity = CreateEntity
                .Empty()
                .AddTransform(transform)
                .AddWorldPosition(transform.position)
                .AddDirection(Vector2.zero)
                .AddSpeed(Speed)
                .AddHeroAnimator(heroAnimator)
                .AddSpriteRenderer(heroAnimator.SpriteRenderer)
                .With(x => x.isHero = true)
                .With(x => x.isTurnedAlongDirection = true)                
                ;
        }
    }
}