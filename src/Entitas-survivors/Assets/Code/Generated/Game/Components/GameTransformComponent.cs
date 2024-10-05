//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherTransform;

    public static Entitas.IMatcher<GameEntity> Transform {
        get {
            if (_matcherTransform == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Transform);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTransform = matcher;
            }

            return _matcherTransform;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Assets.Code.Gameplay.Common.TransformComponent transform { get { return (Assets.Code.Gameplay.Common.TransformComponent)GetComponent(GameComponentsLookup.Transform); } }
    public UnityEngine.Transform Transform { get { return transform.Value; } }
    public bool hasTransform { get { return HasComponent(GameComponentsLookup.Transform); } }

    public GameEntity AddTransform(UnityEngine.Transform newValue) {
        var index = GameComponentsLookup.Transform;
        var component = (Assets.Code.Gameplay.Common.TransformComponent)CreateComponent(index, typeof(Assets.Code.Gameplay.Common.TransformComponent));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceTransform(UnityEngine.Transform newValue) {
        var index = GameComponentsLookup.Transform;
        var component = (Assets.Code.Gameplay.Common.TransformComponent)CreateComponent(index, typeof(Assets.Code.Gameplay.Common.TransformComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveTransform() {
        RemoveComponent(GameComponentsLookup.Transform);
        return this;
    }
}
