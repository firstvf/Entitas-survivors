using Entitas;
using System.Collections.Generic;

namespace Assets.Code.Gameplay.Features.CharacterStats
{
    [Game] public class BaseStats : IComponent { public Dictionary<Stats, float> Value; }
    [Game] public class StatsModifiers : IComponent { public Dictionary<Stats, float> Value; }

    [Game] public class StatChange: IComponent { public Stats Value; }
}