using Assets.Code.Gameplay.Features.Effects;
using Assets.Code.Gameplay.Features.Statuses;
using Entitas;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Armaments
{
    [Game] public class Armament : IComponent { }
    [Game] public class Processed : IComponent { }
    [Game] public class TargetLimit : IComponent { public int Value; }

    [Game] public class EffectSetups : IComponent { public List<EffectSetup> Value; }
    [Game] public class StatusSetups: IComponent { public List<StatusSetup> Value; }
}