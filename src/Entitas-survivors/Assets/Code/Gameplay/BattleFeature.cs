using Assets.Code.Gameplay.Features.Hero;
using Assets.Code.Gameplay.Features.Movement;
using Assets.Code.Gameplay.Input;
using Code.Gameplay.Common.Time;
using Code.Gameplay.Input.Service;
using UnityEngine;

namespace Assets.Code.Gameplay
{
    public class BattleFeature : Feature
    {
        public BattleFeature(GameContext game, ITimeService timeService,IInputService inputService)
        {
            Add(new InputFeature(game, inputService));
            Add(new HeroFeature(game));
            Add(new MovementFeature(game, timeService));
        }
    }
}