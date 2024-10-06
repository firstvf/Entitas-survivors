using Assets.Code.Gameplay.Input.Systems;
using Assets.Code.Infrastructure.Systems;

namespace Assets.Code.Gameplay.Input
{
    public class InputFeature : Feature
    {
        public InputFeature(ISystemFactory systems)
        {
            Add(systems.Create<InitializeInputSystem>());
            Add(systems.Create<EmitInputSystem>());
        }
    }
}