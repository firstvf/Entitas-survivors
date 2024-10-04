using Assets.Code.Gameplay;
using Code.Gameplay.Common.Time;
using UnityEngine;
using Zenject;

namespace Assets.Code.Infrastructure
{
    public class EcsRunner : MonoBehaviour
    {
        private ITimeService _time;
        private GameContext _context;
        private BattleFeature _battleFeature;

        [Inject]
        private void Construct(GameContext context, ITimeService time)
        {
            _context = context;
            _time = time;
        }

        private void Start()
        {
            _battleFeature = new BattleFeature(_context, _time);
            _battleFeature.Initialize();
        }

        private void Update()
        {
            _battleFeature.Execute();
            _battleFeature.Cleanup();
        }

        private void OnDestroy()
        {
            _battleFeature.TearDown();
        }
    }
}