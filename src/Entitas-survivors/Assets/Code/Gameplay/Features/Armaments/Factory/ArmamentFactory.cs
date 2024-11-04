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
            var abilityLevel = _staticDataService.GetAbilityLevel(Abilities.AbilityId.VegetableBolt, level);
            var setup = abilityLevel.ProjectileSetup;

            return CreateEntity.Empty()
                .AddId(_identifier.Next())
                .With(x => x.isArmament = true)
                .AddViewPrefab(abilityLevel.ViewPrefab)
                .AddWorldPosition(at)
                .AddSpeed(setup.Speed)
                .AddEffectSetups(abilityLevel.EffectSetups)
                .AddStatusSetups(abilityLevel.StatusSetups)
                .AddRadius(setup.ContactRadius)
                .AddTargetsBuffer(new List<int>(TARGET_BUFFER_SIZE))
                .AddProcessedTargets(new List<int>(TARGET_BUFFER_SIZE))
                .AddTargetLimit(setup.Pierce)
                .AddLayerMask(CollisionLayer.Enemy.AsMask())                
                .With(x => x.isMovementAvailable = true)
                .With(x => x.isReadyToCollectTargets = true)
                .With(x => x.isCollectingTargetsContinuously = true)
                .With(x => x.isRotationAlignedAlongDirection = true)
                .AddSelfDestructTimer(setup.LifeTime)
                ;
        }

        public GameEntity CreateBouncingVegetableBolt(int level, Vector3 at)
        {
            var abilityLevel = _staticDataService.GetAbilityLevel(Abilities.AbilityId.BouncingVegetableBolt, level);
            var setup = abilityLevel.ProjectileSetup;

            return CreateEntity.Empty()
                .AddId(_identifier.Next())
                .With(x => x.isArmament = true)
                .AddViewPrefab(abilityLevel.ViewPrefab)
                .AddWorldPosition(at)
                .AddSpeed(setup.Speed)
                .AddEffectSetups(abilityLevel.EffectSetups)
                .AddStatusSetups(abilityLevel.StatusSetups)
                .AddRadius(setup.ContactRadius)
                .AddTargetsBuffer(new List<int>(TARGET_BUFFER_SIZE))
                .AddProcessedTargets(new List<int>(TARGET_BUFFER_SIZE))
                .AddTargetLimit(setup.Pierce)
                .AddLayerMask(CollisionLayer.Enemy.AsMask())
                .With(x => x.isMovementAvailable = true)
                .With(x => x.isReadyToCollectTargets = true)
                .With(x => x.isCollectingTargetsContinuously = true)
                .With(x => x.isRotationAlignedAlongDirection = true)
                .AddSelfDestructTimer(setup.LifeTime)
                ;
        }
    }
}