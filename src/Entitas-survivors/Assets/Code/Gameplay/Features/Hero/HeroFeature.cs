using Assets.Code.Gameplay.Features.Hero.Systems;
using Assets.Code.Gameplay.Features.Movement.Systems;

namespace Assets.Code.Gameplay.Features.Hero
{
    public class HeroFeature : Feature
    {
        public HeroFeature(GameContext game)
        {
            Add(new SetHeroDirectionByInputSystem(game));
            Add(new AnimateHeroMoveSystem(game));                  
        }
    }
}