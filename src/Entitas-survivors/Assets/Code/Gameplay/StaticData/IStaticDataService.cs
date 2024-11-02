using Assets.Code.Gameplay.Features.Abilities;
using Assets.Code.Gameplay.Features.Abilities.Configs;

namespace Code.Gameplay.StaticData
{
  public interface IStaticDataService
  {
        AbilityConfig GetAbilityConfig(AbilityId id);
        AbilityLevel GetAbilityLevel(AbilityId id, int level);
        void LoadAll();
  }
}