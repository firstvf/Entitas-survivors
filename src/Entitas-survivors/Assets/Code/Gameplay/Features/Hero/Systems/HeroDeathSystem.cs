using Entitas;

namespace Assets.Code.Gameplay.Features.Hero.Systems
{
    public class HeroDeathSystem : IExecuteSystem
    {
        private IGroup<GameEntity> _heroes;

        public HeroDeathSystem(GameContext game)
        {
            _heroes = game.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.Hero,
                GameMatcher.Dead,
                GameMatcher.HeroAnimator,
                GameMatcher.ProcessingDeath
                ));
        }

        public void Execute()
        {
            foreach (var hero in _heroes)
            {
                hero.isMovementAvailable = false;

                hero.HeroAnimator.PlayDied();
            }
        }
    }

}