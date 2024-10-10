using Assets.Code.Gameplay.Features.Enemies.Enum;
using Code.Gameplay.Features.Enemies.Behaviours;
using Entitas;

namespace Assets.Code.Gameplay.Features.Enemies
{
    [Game] public class Enemy : IComponent { }
    [Game] public class EnemyTypeIdComponent : IComponent { public EnemyTypeId Value; }
    [Game] public class EnemyAnimatorComponent : IComponent { public EnemyAnimator Value; }
}