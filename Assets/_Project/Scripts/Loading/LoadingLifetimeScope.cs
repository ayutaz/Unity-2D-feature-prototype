using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace _Project.Loading
{
    public class LoadingLifetimeScope : LifetimeScope
    {
        [SerializeField] private LoadingView loadingView;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterComponent(loadingView);
            builder.RegisterEntryPoint<LoadingManager>();
        }
    }
}