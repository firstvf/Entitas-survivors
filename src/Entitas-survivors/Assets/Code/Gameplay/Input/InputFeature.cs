using Assets.Code.Gameplay.Input.Systems;
using Code.Gameplay.Input.Service;

namespace Assets.Code.Gameplay.Input
{
    public class InputFeature : Feature
    {
        public InputFeature(GameContext game, IInputService inputService)
        {
            Add(new InitializeInputSystem());
            Add(new EmitInputSystem(game, inputService));
        }
    }
}