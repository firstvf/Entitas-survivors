using Assets.Code.Infrastructure.View.Registrar;
using Code.Gameplay.Common.Visuals;
using Code.Gameplay.Features.Hero.Behaviours;

namespace Assets.Code.Gameplay.Features.Hero.Registrars
{
    public class HeroAnimatorRegistrar : EntityComponentRegistrar
    {
        public HeroAnimator HeroAnimator;

        public override void RegisterComponents()
        {
            Entity
                .AddHeroAnimator(HeroAnimator)
                .AddDamageTakenAnimator(HeroAnimator);

        }

        public override void UnregisterComponents()
        {
            if (Entity.hasHeroAnimator)
                Entity.RemoveHeroAnimator();

            if (Entity.hasDamageTakenAnimator)
                Entity.RemoveDamageTakenAnimator();
        }
    }
}