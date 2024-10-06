using Assets.Code.Gameplay.Cameras.Systems;
using Assets.Code.Gameplay.Features.Hero.Systems;
using Assets.Code.Infrastructure.Systems;

namespace Assets.Code.Gameplay.Features.Hero
{
    public class HeroFeature : Feature
    {
        public HeroFeature(ISystemFactory systems)
        {
            Add(systems.Create<SetHeroDirectionByInputSystem>());
            Add(systems.Create<CameraFollowHeroSystem>());
            Add(systems.Create<AnimateHeroMoveSystem>());            
        }
    }
}