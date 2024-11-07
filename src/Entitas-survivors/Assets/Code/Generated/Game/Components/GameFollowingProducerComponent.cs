//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherFollowingProducer;

    public static Entitas.IMatcher<GameEntity> FollowingProducer {
        get {
            if (_matcherFollowingProducer == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.FollowingProducer);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherFollowingProducer = matcher;
            }

            return _matcherFollowingProducer;
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

    static readonly Assets.Code.Gameplay.Features.Armaments.FollowingProducer followingProducerComponent = new Assets.Code.Gameplay.Features.Armaments.FollowingProducer();

    public bool isFollowingProducer {
        get { return HasComponent(GameComponentsLookup.FollowingProducer); }
        set {
            if (value != isFollowingProducer) {
                var index = GameComponentsLookup.FollowingProducer;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : followingProducerComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}