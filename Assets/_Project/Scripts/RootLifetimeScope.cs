using _Project;
using VContainer;
using VContainer.Unity;

public class RootLifetimeScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        builder.Register<CharacterDataModel>(Lifetime.Singleton);
        builder.Register<InputSystemTest>(Lifetime.Singleton);
    }
}
