using Assets.Code.Gameplay.Features.Enemies.Enum;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Enemies.Factory
{
    public interface IEnemyFactory 
    {
        public GameEntity CreateEnemy(EnemyTypeId typeId, Vector3 at);
    }
}