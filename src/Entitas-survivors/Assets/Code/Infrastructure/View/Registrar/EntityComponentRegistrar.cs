namespace Assets.Code.Infrastructure.View.Registrar
{
    public abstract class EntityComponentRegistrar : EntityDependant, IEntityComponentRegistrar
    {
        public abstract void RegisterComponent();
        public abstract void UnregisterComponent();
    }
}