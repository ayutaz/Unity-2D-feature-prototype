using UnityEngine.SceneManagement;
using VContainer.Unity;

namespace _Project.Root
{
    public class RootManager : IInitializable
    {
        public void Initialize()
        {
            SceneManager.LoadSceneAsync("_Project/Scenes/Loading", LoadSceneMode.Additive);
        }
    }
}