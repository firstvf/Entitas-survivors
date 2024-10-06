using Assets.Code.Infrastructure.View.Registrar;
using Code.Gameplay.Common.Collisions;
using UnityEngine;
using Zenject;

namespace Assets.Code.Infrastructure.View
{
    public class EntityBehaviour : MonoBehaviour, IEntityView
    {
        private GameEntity _entity;
        private ICollisionRegistry _collisionRegistry;

        public GameEntity Entity => _entity;

        [Inject]
        private void Construct(ICollisionRegistry collisionRegistry)
        {
            _collisionRegistry = collisionRegistry;
        }

        public void SetEntity(GameEntity entity)
        {
            _entity = entity;
            _entity.AddView(this);
            _entity.Retain(this);

            foreach (var registrar in GetComponentsInChildren<IEntityComponentRegistrar>())
                registrar.RegisterComponent();

            foreach (var collider in GetComponentsInChildren<Collider2D>(includeInactive: true))
                _collisionRegistry.Register(collider.GetInstanceID(), _entity);
        }

        public void ReleaseEntity()
        {
            foreach (var registrar in GetComponentsInChildren<IEntityComponentRegistrar>())
                registrar.UnregisterComponent();

            foreach (var collider in GetComponentsInChildren<Collider2D>(includeInactive: true))
                _collisionRegistry.Unregister(collider.GetInstanceID());

            _entity.Release(this);
            _entity = null;
        }
    }
}