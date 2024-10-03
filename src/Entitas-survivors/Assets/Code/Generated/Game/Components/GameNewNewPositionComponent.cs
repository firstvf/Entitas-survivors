//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherNewNewPosition;

    public static Entitas.IMatcher<GameEntity> NewNewPosition {
        get {
            if (_matcherNewNewPosition == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.NewNewPosition);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherNewNewPosition = matcher;
            }

            return _matcherNewNewPosition;
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

    public NewNewPosition newNewPosition { get { return (NewNewPosition)GetComponent(GameComponentsLookup.NewNewPosition); } }
    public UnityEngine.Vector3 NewNewPosition { get { return newNewPosition.Value; } }
    public bool hasNewNewPosition { get { return HasComponent(GameComponentsLookup.NewNewPosition); } }

    public GameEntity AddNewNewPosition(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.NewNewPosition;
        var component = (NewNewPosition)CreateComponent(index, typeof(NewNewPosition));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceNewNewPosition(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.NewNewPosition;
        var component = (NewNewPosition)CreateComponent(index, typeof(NewNewPosition));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveNewNewPosition() {
        RemoveComponent(GameComponentsLookup.NewNewPosition);
        return this;
    }
}