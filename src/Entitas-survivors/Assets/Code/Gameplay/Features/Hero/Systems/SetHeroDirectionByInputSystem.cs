using Entitas;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Hero.Systems
{
    public class SetHeroDirectionByInputSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _heroes;
        private readonly IGroup<GameEntity> _input;

        public SetHeroDirectionByInputSystem(GameContext game)
        {
            _heroes = game.GetGroup(GameMatcher.Hero);
            _input = game.GetGroup(GameMatcher.Input);
        }

        public void Execute()
        {
            foreach (var input in _input)
                foreach (var hero in _heroes)
                {
                    hero.isMoving = input.hasAxisInput;

                    if (input.hasAxisInput)                    
                        hero.ReplaceDirection(input.AxisInput.normalized);                    
                }
        }
    }
}