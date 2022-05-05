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
        private readonly PlayerInfoList _playerInfo;
        private const string URL = "https://script.google.com/macros/s/AKfycbzCE73w6cqR7-sk6a3YQ_eIsVMlkt-2uULV7N0hPpRQnXG5A0-IpgIlMz3EBwY9fwC0bw/exec";
        private const string GameInfoSheetName = "gameInfo";
        private const string PlayerInfoSheetName = "playerInfo";

        private LoadingManager(
            LoadingView loadingView,
            CharacterDataModel characterDataModel,
            PlayerInfoList playerInfo
        )
        {
            _playerInfo = playerInfo;
            _loadingView = loadingView;
            _characterDataModel = characterDataModel;
        }

        public async void Start()
        {
            var gameInfo = await GetGameData.GetGameInfo<CharacterInfoList>(URL, GameInfoSheetName);
            _characterDataModel.CharacterInfoList = gameInfo.gameInfo;
            Debug.Log("list count : " + _characterDataModel.CharacterInfoList.Count);

            var playerInfoList = await GetGameData.GetGameInfo<PlayerInfoList>(URL, PlayerInfoSheetName);
            _playerInfo.gameInfo = playerInfoList.gameInfo;
            Debug.Log("moveSpeed : " + _playerInfo.gameInfo[0].moveSpeed + ",color:" + _playerInfo.gameInfo[0].color);

            //見た目上ロードをしている感じに見せたいため、特に処理の意味はない
            for (var time = 1; time <= 10; time++)
            {
                await UniTask.Delay(100);
                _loadingView.SetProgress(time / 10f);
            }

            SceneManager.LoadSceneAsync("_Project/Scenes/Main");
        }
    }
}