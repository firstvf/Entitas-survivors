namespace Assets.Code.Gameplay.Common.Visuals.StatusVisuals
{
    public interface IStatusVisuals
    {
        void ApplyFreeze();
        void ApplyPoison();
        void UnapplyFreeze();
        void UnapplyPoison();
    }
}