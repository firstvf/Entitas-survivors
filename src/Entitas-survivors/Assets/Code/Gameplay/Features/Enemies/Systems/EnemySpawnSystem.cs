using Assets.Code.Gameplay.Common;
using Assets.Code.Gameplay.Features.Enemies.Factory;
using Code.Common.Extensions;
using Code.Gameplay.Cameras.Provider;
using Code.Gameplay.Common.Time;
using Entitas;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Enemies.Systems
{
    public class EnemySpawnSystem : IExecuteSystem
    {
        private const float SPAWN_DISTANCE_GAP = 0.5f;
        private readonly IGroup<GameEntity> _timers;
        private readonly IGroup<GameEntity> _heroes;
        private readonly ITimeService _time;
        private readonly IEnemyFactory _enemyFactory;
        private readonly ICameraProvider _cameraProvider;

        public EnemySpawnSystem(GameContext game, ITimeService time, IEnemyFactory enemyFactory, ICameraProvider cameraProvider)
        {
            _time = time;
            _enemyFactory = enemyFactory;
            _cameraProvider = cameraProvider;
            _timers = game.GetGroup(
                GameMatcher.SpawnTimer
                );

            _heroes = game.GetGroup(
                GameMatcher.AllOf(
                    GameMatcher.Hero,
                    GameMatcher.WorldPosition
                ));
        }

        public void Execute()
        {
            foreach (var hero in _heroes)
                foreach (var timer in _timers)
                {
                    timer.ReplaceSpawnTimer(timer.SpawnTimer - _time.DeltaTime);
                    if (timer.SpawnTimer <= 0)
                    {
                        timer.ReplaceSpawnTimer(GameplayConstants.ENEMY_SPAWN_TIMER);
                        _enemyFactory.CreateEnemy(Enum.EnemyTypeId.Goblin, at: RandomSpawnPosition(hero.WorldPosition));
                    }
                }
        }

        private Vector2 RandomSpawnPosition(Vector3 heroWorldPosition)
        {
            bool startWithHorizontal = Random.Range(0, 2) == 0;

            return startWithHorizontal
                ? HorizontalSpawnPosition(heroWorldPosition)
                : VerticalSpawnPosition(heroWorldPosition);
        }

        private Vector2 HorizontalSpawnPosition(Vector2 heroWorldPosition)
        {
            Vector2[] horizontalDirections = { Vector2.left, Vector2.right };
            Vector2 primaryDirection = horizontalDirections.PickRandom();

            float horizontalOffsetDistance = _cameraProvider.WorldScreenHeight / 2 + SPAWN_DISTANCE_GAP;
            float verticalRandomOffset = Random.Range(-_cameraProvider.WorldScreenHeight / 2, _cameraProvider.WorldScreenWidth / 2);

            return heroWorldPosition + primaryDirection * horizontalOffsetDistance + Vector2.up * verticalRandomOffset;
        }

        private Vector2 VerticalSpawnPosition(Vector2 heroWorldPosition)
        {
            Vector2[] verticalDirections = { Vector2.up, Vector2.down };
            Vector2 primaryDirection = verticalDirections.PickRandom();

            float verticalOffsetDistance = _cameraProvider.WorldScreenHeight / 2 + SPAWN_DISTANCE_GAP;
            float horizontalRandomOffset = Random.Range(-_cameraProvider.WorldScreenHeight / 2, _cameraProvider.WorldScreenWidth / 2);

            return heroWorldPosition + primaryDirection * verticalOffsetDistance + Vector2.right * horizontalRandomOffset;
        }
    }
}