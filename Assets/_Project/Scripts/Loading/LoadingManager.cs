using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using VContainer.Unity;

namespace _Project.Loading
{
    public class LoadingManager : IStartable
    {
        private readonly LoadingView _loadingView;
        private readonly CharacterDataModel _characterDataModel;
        private const string URL = "https://script.google.com/macros/s/AKfycbzCE73w6cqR7-sk6a3YQ_eIsVMlkt-2uULV7N0hPpRQnXG5A0-IpgIlMz3EBwY9fwC0bw/exec";

        private LoadingManager(LoadingView loadingView, CharacterDataModel characterDataModel)
        {
            _loadingView = loadingView;
            _characterDataModel = characterDataModel;
        }

        public async void Start()
        {
            var data = await GetGameData.GetGameInfo<CharacterInfoList>(URL);
            _characterDataModel.CharacterInfoList = data.gameInfo;
            Debug.Log("list count : " + _characterDataModel.CharacterInfoList.Count);

            //見た目上ロードをしている感じに見せたいため、特に処理の意味はない
            for (var time = 1; time <= 10; time++)
            {
                await UniTask.Delay(100);
                _loadingView.SetProgress(time / 10f);
            }

            SceneManager.LoadSceneAsync("_Project/Scenes/Main", LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync("_Project/Scenes/Loading");
        }
    }
}