using Assets.Code.Infrastructure.View.Registrar;

namespace Assets.Code.Gameplay.Common.Registrar
{
    public class TransformRegistrar : EntityComponentRegistrar
    {
        public override void RegisterComponents()
        {
            Entity.AddTransform(transform);
        }

        public override void UnregisterComponents()
        {
            if (Entity.hasTransform)
                Entity.RemoveTransform();
        }
    }
}