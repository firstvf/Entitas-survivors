using Assets.Code.Common.Destruct;
using Assets.Code.Common.Destruct.Systems;
using Assets.Code.Gameplay.Features.Hero;
using Assets.Code.Gameplay.Features.Movement;
using Assets.Code.Gameplay.Input;
using Assets.Code.Infrastructure.Systems;

namespace Assets.Code.Gameplay
{
    public class BattleFeature : Feature
    {
        public BattleFeature(ISystemFactory systems)
        {
            Add(systems.Create<InputFeature>());
            Add(systems.Create<HeroFeature>());
            Add(systems.Create<MovementFeature>());            
            Add(systems.Create<ProcessDestructedFeature>());            
        }
    }
}       