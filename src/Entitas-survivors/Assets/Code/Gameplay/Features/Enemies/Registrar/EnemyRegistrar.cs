using Assets.Code.Gameplay.Features.Enemies.Enum;
using Assets.Code.Infrastructure.View.Registrar;
using Code.Common.Extensions;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Enemies.Registrar
{
    public class EnemyRegistrar : EntityComponentRegistrar
    {
        public float HP = 3f;
        public float Damage = 1f;
        public float Speed = 1f;

        public override void RegisterComponents()
        {
            Entity
             .AddEnemyTypeId(EnemyTypeId.Goblin)
             .AddWorldPosition(transform.position)
             .AddDirection(Vector2.zero)
             .AddSpeed(Speed)
             .AddCurrentHP(HP)
             .AddMaxHP(HP)
             .AddDamage(Damage)
             .AddTargetsBuffer(new List<int>(1))
             .AddRadius(0.3f)
             .AddCollectTargetsInterval(0.5f)
             .AddCollectTargetsTimer(0)
             .AddLayerMask(CollisionLayer.Hero.AsMask())
             .With(x => x.isEnemy = true)
             .With(x => x.isTurnedAlongDirection = true)
             ;
        }

        public override void UnregisterComponents()
        {

        }
    }
}