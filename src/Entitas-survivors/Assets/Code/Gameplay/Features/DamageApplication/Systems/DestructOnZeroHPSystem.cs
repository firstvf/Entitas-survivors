using Entitas;

namespace Assets.Code.Gameplay.Features.DamageApplication.Systems
{
    public class DestructOnZeroHPSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _entities;

        public DestructOnZeroHPSystem(GameContext game)
        {
            _entities = game.GetGroup(GameMatcher.CurrentHP);
        }

        public void Execute()
        {
            foreach (var entity in _entities)
                if (entity.CurrentHP <= 0)
                    entity.isDestructed = true;
        }
    }
}