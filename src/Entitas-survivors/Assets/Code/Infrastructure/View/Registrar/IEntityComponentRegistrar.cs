namespace Assets.Code.Infrastructure.View.Registrar
{
    public interface IEntityComponentRegistrar
    {
        void RegisterComponent();
        void UnregisterComponent();
    }
}