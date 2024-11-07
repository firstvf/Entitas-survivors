using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Abilities
{
    [Game] public class AbilityIdComponent : IComponent { public AbilityId Value; }
    [Game] public class ParentAbility : IComponent { [EntityIndex] public AbilityId Value; }
    [Game] public class VegetableBoltAbility : IComponent { }
    [Game] public class BouncingVegetableBoltAbility : IComponent { }
    [Game] public class OrbitingMushroomAbility : IComponent { }
    [Game] public class GarlicAuraAbility : IComponent { }    
}