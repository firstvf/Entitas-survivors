//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class GameComponentsLookup {

    public const int Id = 0;
    public const int WorldPosition = 1;
    public const int Direction = 2;
    public const int Moving = 3;
    public const int Speed = 4;

    public const int TotalComponents = 5;

    public static readonly string[] componentNames = {
        "Id",
        "WorldPosition",
        "Direction",
        "Moving",
        "Speed"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(Assets.Code.Gameplay.Common.Id),
        typeof(Assets.Code.Gameplay.Common.WorldPosition),
        typeof(Assets.Code.Gameplay.Features.Movement.Direction),
        typeof(Assets.Code.Gameplay.Features.Movement.Moving),
        typeof(Assets.Code.Gameplay.Features.Movement.Speed)
    };
}
