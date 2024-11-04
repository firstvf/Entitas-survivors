//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherEffectValue;

    public static Entitas.IMatcher<GameEntity> EffectValue {
        get {
            if (_matcherEffectValue == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EffectValue);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEffectValue = matcher;
            }

            return _matcherEffectValue;
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

    public Assets.Code.Gameplay.Features.Effects.EffectValue effectValue { get { return (Assets.Code.Gameplay.Features.Effects.EffectValue)GetComponent(GameComponentsLookup.EffectValue); } }
    public float EffectValue { get { return effectValue.Value; } }
    public bool hasEffectValue { get { return HasComponent(GameComponentsLookup.EffectValue); } }

    public GameEntity AddEffectValue(float newValue) {
        var index = GameComponentsLookup.EffectValue;
        var component = (Assets.Code.Gameplay.Features.Effects.EffectValue)CreateComponent(index, typeof(Assets.Code.Gameplay.Features.Effects.EffectValue));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceEffectValue(float newValue) {
        var index = GameComponentsLookup.EffectValue;
        var component = (Assets.Code.Gameplay.Features.Effects.EffectValue)CreateComponent(index, typeof(Assets.Code.Gameplay.Features.Effects.EffectValue));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveEffectValue() {
        RemoveComponent(GameComponentsLookup.EffectValue);
        return this;
    }
}
