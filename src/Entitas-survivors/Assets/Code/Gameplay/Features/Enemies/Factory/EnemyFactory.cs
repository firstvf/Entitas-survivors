using Assets.Code.Gameplay.Features.Enemies.Enum;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Infrastructure.Identifiers;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Enemies.Factory
{
    public class EnemyFactory :IEnemyFactory
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
            return CreateEntity.Empty()
           .AddId(_identifiers.Next())
           .AddEnemyTypeId(EnemyTypeId.Goblin)
           .AddWorldPosition(position)
           .AddDirection(Vector2.zero)
           .AddSpeed(1)
           .AddCurrentHP(3)
           .AddMaxHP(3)
           .AddDamage(1)
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