using Assets.Code.Common.Destruct;
using Assets.Code.Gameplay.Features.Abilities;
using Assets.Code.Gameplay.Features.Armaments;
using Assets.Code.Gameplay.Features.EffectApplication;
using Assets.Code.Gameplay.Features.Effects;
using Assets.Code.Gameplay.Features.Enemies;
using Assets.Code.Gameplay.Features.Hero;
using Assets.Code.Gameplay.Features.Movement;
using Assets.Code.Gameplay.Features.Statuses;
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
            Add(systems.Create<EffectFeature>());
            Add(systems.Create<StatusFeature>());
            //
            Add(systems.Create<CollectTargetFeature>());
            Add(systems.Create<EffectApplicationFeature>());
            //
            Add(systems.Create<ProcessDestructedFeature>());
        }
    }
}