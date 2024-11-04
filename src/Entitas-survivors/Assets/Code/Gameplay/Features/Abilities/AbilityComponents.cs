using Entitas;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Abilities
{
    [Game] public class AbilityIdComponent : IComponent { public AbilityId Value; }
    [Game] public class VegetableBoltAbility : IComponent { }
    [Game] public class BouncingVegetableBoltAbility : IComponent { }
}