using Assets.Code.Common.Destruct;
using Assets.Code.Gameplay.Features.Abilities;
using Assets.Code.Gameplay.Features.Armaments;
using Assets.Code.Gameplay.Features.DamageApplication;
using Assets.Code.Gameplay.Features.Enemies;
using Assets.Code.Gameplay.Features.Hero;
using Assets.Code.Gameplay.Features.Movement;
using Assets.Code.Gameplay.Features.TargetCollection;
using Assets.Code.Gameplay.Input;
using Assets.Code.Infrastructure.Systems;
using Assets.Code.Infrastructure.View;

namespace Assets.Code.Gameplay
{
    public class BattleFeature : Feature
    {
        public BattleFeature(ISystemFactory systems)
        {
            //
            Add(systems.Create<InputFeature>());
            Add(systems.Create<BindViewFeature>());
            //
            Add(systems.Create<HeroFeature>());
            Add(systems.Create<EnemyFeature>());
            Add(systems.Create<DeathFeature>());
            //
            Add(systems.Create<MovementFeature>());
            Add(systems.Create<AbilityFeature>());
            //
            Add(systems.Create<ArmamentFeature>());
            //
            Add(systems.Create<CollectTargetFeature>());
            Add(systems.Create<DamageApplicationFeature>());
            //
            Add(systems.Create<ProcessDestructedFeature>());
        }
    }
}