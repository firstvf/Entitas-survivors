﻿using Code.Gameplay.Common.Visuals;
using DG.Tweening;
using UnityEngine;

namespace Code.Gameplay.Features.Hero.Behaviours
{
  public class HeroAnimator : MonoBehaviour, IDamageTakenAnimator
  {
    private static readonly int OverlayIntensityProperty = Shader.PropertyToID("_OverlayIntensity");
    
    private readonly int _isMovingHash = Animator.StringToHash("isMoving");
    private readonly int _attackHash = Animator.StringToHash("attack");
    private readonly int _diedHash = Animator.StringToHash("died");
    private Material _material => SpriteRenderer.material;

    public Animator Animator;
    public SpriteRenderer SpriteRenderer;

    public void PlayMove() => Animator.SetBool(_isMovingHash, true);
    public void PlayIdle() => Animator.SetBool(_isMovingHash, false);

    public void PlayAttack() => Animator.SetTrigger(_attackHash);

    public void PlayDied() => Animator.SetTrigger(_diedHash);

    public void PlayDamageTaken()
    {
      if (DOTween.IsTweening(_material))
        return;
      
      _material.DOFloat(0.5f, OverlayIntensityProperty, 0.15f)
        .OnComplete(() =>
        {
          if (SpriteRenderer)
            _material.DOFloat(0, OverlayIntensityProperty, 0.15f);
        });
    }
    
    public void ResetAll()
    {
      Animator.ResetTrigger(_attackHash);
      Animator.ResetTrigger(_diedHash);
    }
  }
}