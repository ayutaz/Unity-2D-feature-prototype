using UnityEngine;
using VContainer.Unity;

namespace _Project.Main
{
    public class MainManager : IStartable
    {
        private readonly CharacterDataModel _characterDataModel;
        private readonly PlayerInfoList _playerInfoList;

        private MainManager(CharacterDataModel characterDataModel, PlayerInfoList playerInfoList)
        {
            _characterDataModel = characterDataModel;
            _playerInfoList = playerInfoList;
        }

        public void Start()
        {
            Debug.Log($"in character list : {_characterDataModel.CharacterInfoList.Count}");
        }
    }
}