using Assets.Code.Infrastructure.Systems;
using Assets.Code.Infrastructure.View.Systems;

namespace Assets.Code.Infrastructure.View
{
    public sealed class BindViewFeature : Feature
    {
        public BindViewFeature(ISystemFactory systems)
        {
            Add(systems.Create<BindEntityViewFromPathSystem>());
            Add(systems.Create<BindEntityViewFromPrefabSystem>());
        }
    }
}