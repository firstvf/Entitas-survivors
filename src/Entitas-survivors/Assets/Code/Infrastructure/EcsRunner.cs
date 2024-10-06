using Assets.Code.Gameplay;
using Assets.Code.Infrastructure.Systems;
using UnityEngine;
using Zenject;

namespace Assets.Code.Infrastructure
{
    public class EcsRunner : MonoBehaviour
    {
        private BattleFeature _battleFeature;
        private ISystemFactory _systemFactory;

        [Inject]
        private void Construct(ISystemFactory systemFactory)
        {
            _systemFactory = systemFactory;            
        }

        private void Start()
        {
            _battleFeature = _systemFactory.Create<BattleFeature>();
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