﻿using Entitas;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Effects.Systems
{
    public class ProcessHealEffectSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _effects;

        public ProcessHealEffectSystem(GameContext game)
        {
            _effects = game.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.HealEffect,
                GameMatcher.TargetId,
                GameMatcher.EffectValue
                ));
        }

        public void Execute()
        {
            foreach (var effect in _effects)
            {
                var target = effect.Target();

                effect.isProcessed = true;

                if (target.isDead)
                    continue;

                if (target.hasMaxHP && target.hasCurrentHP)
                {
                    float newValue = Mathf.Min(target.CurrentHP + effect.EffectValue, target.MaxHP);
                    target.ReplaceCurrentHP(newValue);
                }
            }
        }
    }
}