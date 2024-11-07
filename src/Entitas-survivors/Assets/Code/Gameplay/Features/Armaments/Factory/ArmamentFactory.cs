using Assets.Code.Gameplay.Features.Abilities;
using Assets.Code.Gameplay.Features.Abilities.Configs;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Armaments.Factory
{
    public class ArmamentFactory : IArmamentFactory
    {
        private const int TARGET_BUFFER_SIZE = 16;

        private readonly IIdentifierService _identifier;
        private readonly IStaticDataService _staticDataService;

        public ArmamentFactory(IIdentifierService identifier, IStaticDataService staticDataService)
        {
            _identifier = identifier;
            _staticDataService = staticDataService;
        }

        public GameEntity CreateVegetableBolt(int level, Vector3 at)
        {
            var abilityLevel = _staticDataService.GetAbilityLevel(AbilityId.VegetableBolt, level);
            var setup = abilityLevel.ProjectileSetup;

            return CreateProjectileEntity(at, abilityLevel, setup)
                .AddParentAbility(AbilityId.VegetableBolt)
                .With(x => x.isRotationAlignedAlongDirection = true)
                ;
        }

        public GameEntity CreateEffectAura(AbilityId parentAbilityId, int producerId, int level)
        {
            AbilityLevel abilityLevel = _staticDataService.GetAbilityLevel(AbilityId.GarlicAura, level);
            AurasSetup setup = abilityLevel.AuraSetup;

            return CreateEntity.Empty()
                .AddId(_identifier.Next())
                .AddViewPrefab(abilityLevel.ViewPrefab)
                .With(x => x.AddEffectSetups(abilityLevel.EffectSetups)
                , when: !abilityLevel.EffectSetups.IsNullOrEmpty())
                .With(x => x.AddStatusSetups(abilityLevel.StatusSetups)
                , when: !abilityLevel.StatusSetups.IsNullOrEmpty())
                .AddProducerId(producerId)
                .AddTargetsBuffer(new List<int>(TARGET_BUFFER_SIZE))
                .AddLayerMask(CollisionLayer.Enemy.AsMask())
                .AddRadius(setup.Radius)
                .AddCollectTargetsInterval(setup.Interval)
                .AddCollectTargetsTimer(0)
                .AddParentAbility(parentAbilityId)
                .AddWorldPosition(Vector3.zero)
                .With(x=>x.isFollowingProducer = true)
                ;
        }

        public GameEntity CreateBouncingVegetableBolt(int level, Vector3 at)
        {
            var abilityLevel = _staticDataService.GetAbilityLevel(AbilityId.BouncingVegetableBolt, level);
            var setup = abilityLevel.ProjectileSetup;

            return CreateProjectileEntity(at, abilityLevel, setup)
                .AddParentAbility(AbilityId.BouncingVegetableBolt)
                .With(x => x.isRotationAlignedAlongDirection = true)
                ;
        }

        public GameEntity CreateOrbitingMushroom(int level, Vector3 at, float phase)
        {
            var abilityLevel = _staticDataService.GetAbilityLevel(AbilityId.OrbitingMushroom, level);
            var setup = abilityLevel.ProjectileSetup;

            return CreateProjectileEntity(at, abilityLevel, setup)
                .AddParentAbility(AbilityId.OrbitingMushroom)
                .AddOrbitPhase(phase)
                .AddOrbitRadius(setup.OrbitRadius)
                ;
        }

        private GameEntity CreateProjectileEntity(Vector3 at, AbilityLevel abilityLevel, ProjectileSetup setup)
        {
            return CreateEntity.Empty()
                .AddId(_identifier.Next())
                .With(x => x.isArmament = true)
                .AddViewPrefab(abilityLevel.ViewPrefab)
                .AddWorldPosition(at)
                .AddSpeed(setup.Speed)

                .With(x => x.AddEffectSetups(abilityLevel.EffectSetups)
                , when: !abilityLevel.EffectSetups.IsNullOrEmpty())
                .With(x => x.AddStatusSetups(abilityLevel.StatusSetups)
                , when: !abilityLevel.StatusSetups.IsNullOrEmpty())
                .With(x => x.AddTargetLimit(setup.Pierce), when: setup.Pierce > 0)

                .AddRadius(setup.ContactRadius)
                .AddTargetsBuffer(new List<int>(TARGET_BUFFER_SIZE))
                .AddProcessedTargets(new List<int>(TARGET_BUFFER_SIZE))
                .AddLayerMask(CollisionLayer.Enemy.AsMask())
                .With(x => x.isMovementAvailable = true)
                .With(x => x.isReadyToCollectTargets = true)
                .With(x => x.isCollectingTargetsContinuously = true)
                .AddSelfDestructTimer(setup.LifeTime);
        }
    }
}