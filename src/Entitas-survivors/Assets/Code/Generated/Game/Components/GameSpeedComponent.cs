//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherSpeed;

    public static Entitas.IMatcher<GameEntity> Speed {
        get {
            if (_matcherSpeed == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Speed);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSpeed = matcher;
            }

            return _matcherSpeed;
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

    public Assets.Code.Gameplay.Features.Movement.Speed speed { get { return (Assets.Code.Gameplay.Features.Movement.Speed)GetComponent(GameComponentsLookup.Speed); } }
    public float Speed { get { return speed.Value; } }
    public bool hasSpeed { get { return HasComponent(GameComponentsLookup.Speed); } }

    public GameEntity AddSpeed(float newValue) {
        var index = GameComponentsLookup.Speed;
        var component = (Assets.Code.Gameplay.Features.Movement.Speed)CreateComponent(index, typeof(Assets.Code.Gameplay.Features.Movement.Speed));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceSpeed(float newValue) {
        var index = GameComponentsLookup.Speed;
        var component = (Assets.Code.Gameplay.Features.Movement.Speed)CreateComponent(index, typeof(Assets.Code.Gameplay.Features.Movement.Speed));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveSpeed() {
        RemoveComponent(GameComponentsLookup.Speed);
        return this;
    }
}
