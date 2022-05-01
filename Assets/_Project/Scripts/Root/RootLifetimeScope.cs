using VContainer;
using VContainer.Unity;

namespace _Project.Root
{
    public class RootLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<CharacterDataModel>(Lifetime.Singleton);
            builder.Register<InputSystemTest>(Lifetime.Singleton);
            builder.RegisterEntryPoint<RootManager>();
        }
    }
}