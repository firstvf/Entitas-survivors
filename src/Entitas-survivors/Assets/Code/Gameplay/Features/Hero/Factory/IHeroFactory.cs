using UnityEngine;

namespace Assets.Code.Gameplay.Features.Hero.Factory
{
    public interface IHeroFactory
    {
        public GameEntity CreateHero(Vector3 at);
    }
}