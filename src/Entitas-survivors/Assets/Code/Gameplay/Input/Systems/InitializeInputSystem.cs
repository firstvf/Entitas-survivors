using Code.Common.Entity;
using Entitas;
using UnityEngine;

namespace Assets.Code.Gameplay.Input.Systems
{
    public class InitializeInputSystem : IInitializeSystem
    {
        public void Initialize()
        {
            CreateEntity.Empty()
                .isInput = true;
        }
    }
}