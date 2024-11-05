using Assets.Code.Gameplay.Features.CharacterStats;
using Assets.Code.Gameplay.Features.Effects;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Infrastructure.Identifiers;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Enemies.Factory
{
    public class EnemyFactory : IEnemyFactory
    {
        private readonly IIdentifierService _identifiers;

        public EnemyFactory(IIdentifierService identifiers)
        {
            _identifiers = identifiers;
        }

        public GameEntity CreateEnemy(EnemyTypeId typeId, Vector3 position)
        {
            switch (typeId)
            {
                case EnemyTypeId.Goblin:
                    return CreateGoblin(position);
            }

            throw new Exception($"Enemy with type id {typeId} does not exist");
        }

        private GameEntity CreateGoblin(Vector2 position)
        {
            Dictionary<Stats, float> baseStats = InitStats.EmptyStatDictionary()
                .With(x => x[Stats.Speed] = 1)
                .With(x => x[Stats.MaxHp] = 3)
                .With(x => x[Stats.Damage] = 1);

            return CreateEntity.Empty()
             .AddId(_identifiers.Next())
             .AddEnemyTypeId(EnemyTypeId.Goblin)
             .AddWorldPosition(position)
             .AddDirection(Vector2.zero)
             .AddBaseStats(baseStats)
             .AddStatsModifiers(InitStats.EmptyStatDictionary())
             .AddSpeed(baseStats[Stats.Speed])
             .AddCurrentHP(baseStats[Stats.MaxHp])
             .AddMaxHP(baseStats[Stats.MaxHp])
             .AddEffectSetups(new List<EffectSetup>() { new() { EffectTypeId = EffectTypeId.Damage, Value = baseStats[Stats.Damage] } })
             .AddRadius(0.3f)
             .AddTargetsBuffer(new List<int>(1))
             .AddCollectTargetsInterval(0.5f)
             .AddCollectTargetsTimer(0)
             .AddLayerMask(CollisionLayer.Hero.AsMask())
             .AddViewPath("Gameplay/Enemies/Goblins/Torch/goblin_torch_blue")
             .With(x => x.isEnemy = true)
             .With(x => x.isTurnedAlongDirection = true)
             .With(x => x.isMovementAvailable = true);
        }
    }
}