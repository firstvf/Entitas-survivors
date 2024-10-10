using Entitas;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.DamageApplication.Systems
{
    public partial class ApplyDamageOnTargetsSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _damageDealers;
        private readonly GameContext _game;

        public ApplyDamageOnTargetsSystem(GameContext game)
        {
            _game = game;
            _damageDealers = game.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.Damage,
                GameMatcher.DamageTakenAnimator
                ));
        }

        public void Execute()
        {
            foreach (var damageDealer in _damageDealers)
                foreach (var targetId in damageDealer.TargetsBuffer)
                {
                    var target = _game.GetEntityWithId(targetId);

                    if (target.hasCurrentHP)
                    {
                        target.ReplaceCurrentHP(target.CurrentHP - damageDealer.Damage);

                        if (target.hasDamageTakenAnimator)
                            target.DamageTakenAnimator.PlayDamageTaken();
                    }

                }
        }
    }
}