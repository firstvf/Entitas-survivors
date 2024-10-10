namespace Assets.Code.Infrastructure.View.Registrar
{
    public interface IEntityComponentRegistrar
    {
        void RegisterComponents();
        void UnregisterComponents();
    }
}