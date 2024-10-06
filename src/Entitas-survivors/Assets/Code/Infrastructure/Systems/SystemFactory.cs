using Entitas;
using UnityEngine;
using Zenject;

namespace Assets.Code.Infrastructure.Systems
{
    public class SystemFactory : ISystemFactory
    {
        private readonly DiContainer _container;

        public SystemFactory(DiContainer container)
        {
            _container = container;
        }

        public T Create<T>() where T : ISystem
        => _container.Instantiate<T>();

        public T Create<T>(params object[] args) where T : ISystem
        => _container.Instantiate<T>(args);
    }
}