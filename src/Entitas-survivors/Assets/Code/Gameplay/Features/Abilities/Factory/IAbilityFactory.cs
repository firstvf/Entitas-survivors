namespace Assets.Code.Gameplay.Features.Abilities.Factory
{
    public interface IAbilityFactory
    {
        GameEntity CreateVegetableBoltAbility(int level);
        GameEntity CreateBouncingVegetableBoltAbility(int level);
        GameEntity CreateOrbitingMushroomAbility(int level);        
        GameEntity CreateGarlicAuraAbility();
    }
}