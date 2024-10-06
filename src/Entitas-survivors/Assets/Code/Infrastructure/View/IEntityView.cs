using UnityEngine;

namespace Assets.Code.Infrastructure.View
{
    public interface IEntityView
    {
        GameEntity Entity { get; }
        void ReleaseEntity();
        void SetEntity(GameEntity entity);
        GameObject gameObject { get; }
    }
}