//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherStatsModifiers;

    public static Entitas.IMatcher<GameEntity> StatsModifiers {
        get {
            if (_matcherStatsModifiers == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.StatsModifiers);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherStatsModifiers = matcher;
            }

            return _matcherStatsModifiers;
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

    public Assets.Code.Gameplay.Features.CharacterStats.StatsModifiers statsModifiers { get { return (Assets.Code.Gameplay.Features.CharacterStats.StatsModifiers)GetComponent(GameComponentsLookup.StatsModifiers); } }
    public System.Collections.Generic.Dictionary<Assets.Code.Gameplay.Features.CharacterStats.Stats, float> StatsModifiers { get { return statsModifiers.Value; } }
    public bool hasStatsModifiers { get { return HasComponent(GameComponentsLookup.StatsModifiers); } }

    public GameEntity AddStatsModifiers(System.Collections.Generic.Dictionary<Assets.Code.Gameplay.Features.CharacterStats.Stats, float> newValue) {
        var index = GameComponentsLookup.StatsModifiers;
        var component = (Assets.Code.Gameplay.Features.CharacterStats.StatsModifiers)CreateComponent(index, typeof(Assets.Code.Gameplay.Features.CharacterStats.StatsModifiers));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceStatsModifiers(System.Collections.Generic.Dictionary<Assets.Code.Gameplay.Features.CharacterStats.Stats, float> newValue) {
        var index = GameComponentsLookup.StatsModifiers;
        var component = (Assets.Code.Gameplay.Features.CharacterStats.StatsModifiers)CreateComponent(index, typeof(Assets.Code.Gameplay.Features.CharacterStats.StatsModifiers));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveStatsModifiers() {
        RemoveComponent(GameComponentsLookup.StatsModifiers);
        return this;
    }
}