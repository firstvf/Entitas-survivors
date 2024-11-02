using Assets.Code.Gameplay.Features.TargetCollection.Systems;
using Assets.Code.Infrastructure.Systems;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.TargetCollection
{
    public class CollectTargetFeature : Feature
    {
        public CollectTargetFeature(ISystemFactory systems)
        {
            Add(systems.Create<CollectTargetsIntervalSystem>());
            //
            Add(systems.Create<CastForTargetsNoLimitSystem>());
            Add(systems.Create<CastForTargetsWithLimitSystem>());
            //
            Add(systems.Create<CleanupTargetBuffersSystem>());
        }
    }
}