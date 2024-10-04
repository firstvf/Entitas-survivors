using Assets.Code.Gameplay.Features.Movement.Systems;
using Code.Gameplay.Common.Time;

namespace Assets.Code.Gameplay.Features.Movement
{
    public class MovementFeature : Feature
    {
        private readonly GameContext _context;
        private readonly ITimeService _time;

        public MovementFeature(GameContext context, ITimeService time)
        {
            _context = context;
            _time = time;

            Add(new DirectionalDeltaMoveSystem(_context, _time));
        }
    }
}