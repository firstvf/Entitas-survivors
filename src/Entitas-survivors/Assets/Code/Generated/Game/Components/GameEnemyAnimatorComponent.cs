//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherEnemyAnimator;

    public static Entitas.IMatcher<GameEntity> EnemyAnimator {
        get {
            if (_matcherEnemyAnimator == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EnemyAnimator);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEnemyAnimator = matcher;
            }

            return _matcherEnemyAnimator;
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

    public Assets.Code.Gameplay.Features.Enemies.EnemyAnimatorComponent enemyAnimator { get { return (Assets.Code.Gameplay.Features.Enemies.EnemyAnimatorComponent)GetComponent(GameComponentsLookup.EnemyAnimator); } }
    public Code.Gameplay.Features.Enemies.Behaviours.EnemyAnimator EnemyAnimator { get { return enemyAnimator.Value; } }
    public bool hasEnemyAnimator { get { return HasComponent(GameComponentsLookup.EnemyAnimator); } }

    public GameEntity AddEnemyAnimator(Code.Gameplay.Features.Enemies.Behaviours.EnemyAnimator newValue) {
        var index = GameComponentsLookup.EnemyAnimator;
        var component = (Assets.Code.Gameplay.Features.Enemies.EnemyAnimatorComponent)CreateComponent(index, typeof(Assets.Code.Gameplay.Features.Enemies.EnemyAnimatorComponent));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceEnemyAnimator(Code.Gameplay.Features.Enemies.Behaviours.EnemyAnimator newValue) {
        var index = GameComponentsLookup.EnemyAnimator;
        var component = (Assets.Code.Gameplay.Features.Enemies.EnemyAnimatorComponent)CreateComponent(index, typeof(Assets.Code.Gameplay.Features.Enemies.EnemyAnimatorComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveEnemyAnimator() {
        RemoveComponent(GameComponentsLookup.EnemyAnimator);
        return this;
    }
}