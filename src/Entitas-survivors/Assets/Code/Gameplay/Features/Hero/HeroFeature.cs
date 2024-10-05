using Assets.Code.Gameplay.Cameras.Systems;
using Assets.Code.Gameplay.Features.Hero.Systems;
using Assets.Code.Gameplay.Features.Movement.Systems;
using Code.Gameplay.Cameras.Provider;

namespace Assets.Code.Gameplay.Features.Hero
{
    public class HeroFeature : Feature
    {
        public HeroFeature(GameContext game, ICameraProvider cameraProvider)
        {
            Add(new SetHeroDirectionByInputSystem(game));
            Add(new CameraFollowHeroSystem(game, cameraProvider));
            Add(new AnimateHeroMoveSystem(game));
        }
    }
}