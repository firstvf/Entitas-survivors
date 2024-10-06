using Assets.Code.Common.Destruct.Systems;
using Assets.Code.Infrastructure.Systems;
using UnityEngine;

namespace Assets.Code.Common.Destruct
{
    public class ProcessDestructedFeature : Feature
    {
        public ProcessDestructedFeature(ISystemFactory systems)
        {
            Add(systems.Create<SelfDestructTimerSystem>());

            Add(systems.Create<CleanupGameDestructedSystem>());
            Add(systems.Create<CleanupGameDestructedViewSystem>());
        }
    }
}