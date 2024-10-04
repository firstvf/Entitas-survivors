using Code.Gameplay.Common.Time;
using UnityEngine;

namespace Assets.Code.Gameplay
{
    public class BattleFeature : Feature
    {
        private readonly GameContext _context;
        private readonly ITimeService _time;

        public BattleFeature(GameContext context, ITimeService time)
        {
            _context = context;
            _time = time;

            Add(new)
        }
    }
}