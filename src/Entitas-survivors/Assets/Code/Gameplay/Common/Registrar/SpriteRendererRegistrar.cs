using Assets.Code.Infrastructure.View.Registrar;
using UnityEngine;

namespace Assets.Code.Common.Registrar
{
    public class SpriteRendererRegistrar : EntityComponentRegistrar
    {
        public SpriteRenderer SpriteRenderer;

        public override void RegisterComponents()
        {
            Entity.AddSpriteRenderer(SpriteRenderer);
        }

        public override void UnregisterComponents()
        {
            if (Entity.hasSpriteRenderer)
                Entity.RemoveSpriteRenderer();
        }
    }
}