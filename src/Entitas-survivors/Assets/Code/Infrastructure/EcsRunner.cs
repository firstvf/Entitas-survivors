using Assets.Code.Gameplay;
using Code.Gameplay.Cameras.Provider;
using Code.Gameplay.Common.Time;
using Code.Gameplay.Input.Service;
using UnityEngine;
using Zenject;

namespace Assets.Code.Infrastructure
{
    public class EcsRunner : MonoBehaviour
    {
        private ITimeService _timeService;
        private IInputService _inputService;
        private GameContext _game;
        private BattleFeature _battleFeature;
        private ICameraProvider _cameraProvider;

        [Inject]
        private void Construct(GameContext game, ITimeService timeService, IInputService inputService, ICameraProvider cameraProvider)
        {
            _game = game;
            _timeService = timeService;
            _inputService = inputService;
            _cameraProvider = cameraProvider;
        }

        private void Start()
        {
            _battleFeature = new BattleFeature(_game, _timeService, _inputService, _cameraProvider);
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