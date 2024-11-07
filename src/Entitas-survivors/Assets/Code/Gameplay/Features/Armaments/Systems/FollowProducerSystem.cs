using Entitas;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Armaments.Systems
{
    public class FollowProducerSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _followers;
        private readonly IGroup<GameEntity> _producers;

        public FollowProducerSystem(GameContext game)
        {
            _followers = game.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.WorldPosition,
                GameMatcher.FollowingProducer,
                GameMatcher.ProducerId
                ));

            _producers = game.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.Id,
                GameMatcher.WorldPosition
                ));
        }

        public void Execute()
        {
            foreach (var follower in _followers)
                foreach (var producer in _producers)
                {
                    if (follower.ProducerId == producer.Id)
                    {
                        follower.ReplaceWorldPosition(producer.WorldPosition);
                    }
                }
        }
    }
}