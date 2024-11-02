using Assets.Code.Gameplay.Common;
using Code.Common.Entity;
using Entitas;

namespace Assets.Code.Gameplay.Features.Enemies.Systems
{
    public class InitializeSpawnTimerSystem : IInitializeSystem
    {
        public void Initialize()
        {
            CreateEntity.Empty().AddSpawnTimer(GameplayConstants.ENEMY_SPAWN_TIMER);
        }
    }
}