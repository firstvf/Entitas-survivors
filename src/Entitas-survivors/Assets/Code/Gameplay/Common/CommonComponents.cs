﻿using Entitas;
using UnityEngine;

namespace Assets.Code.Gameplay.Common
{
    [Game] public class Id : IComponent { public int Value; }
    [Game] public class WorldPosition : IComponent { public Vector3 Value; }
}