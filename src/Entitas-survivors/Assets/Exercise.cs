using Entitas;
using UnityEngine;

public class Exercise : MonoBehaviour
{
    public Exercise()
    {
        GameEntity entity = null;

        int id = entity.Id;


        entity
            .AddId(1)
            .AddWorldPosition(Vector3.zero);
    }
}

public class Id : IComponent { public int Value; }
public class WorldPosition : IComponent { public Vector3 Value; }
public class NewNewPosition : IComponent { public Vector3 Value; }