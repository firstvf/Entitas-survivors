using Assets.Code.Infrastructure.View;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Armaments.Behaviours
{
    public class AuraSizeListener : EntityDependant
    {
        public Transform Container;
        private float _radiusPrev;

        private void Update()
        {
            SetAuraScale();
        }

        private void SetAuraScale()
        {
            if (Mathf.Abs(Entity.Radius - _radiusPrev) < Mathf.Epsilon)
                return;

            _radiusPrev = Entity.Radius;
            float scale = Entity.Radius * 2;
            Container.localScale = new Vector3(scale, scale, scale);
        }
    }
}