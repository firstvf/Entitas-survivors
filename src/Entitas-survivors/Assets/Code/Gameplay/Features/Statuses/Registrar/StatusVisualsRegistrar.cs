using Assets.Code.Gameplay.Common.Visuals.StatusVisuals;
using Assets.Code.Infrastructure.View.Registrar;
using Code.Gameplay.Features.Enemies.Behaviours;

namespace Assets.Code.Gameplay.Features.Statuses.Registrar
{
    public class StatusVisualsRegistrar : EntityComponentRegistrar
    {
        public StatusVisuals StatusVisuals;

        public override void RegisterComponents()
        {
            Entity
                .AddStatusVisuals(StatusVisuals);
        }

        public override void UnregisterComponents()
        {
            if (Entity.hasStatusVisuals)
                Entity.RemoveStatusVisuals();
        }
    }
}