using UnityEngine;
using VContainer.Unity;

namespace _Project.Main
{
    public class MainManager : IStartable
    {
        private readonly CharacterDataModel _characterDataModel;

        private MainManager(CharacterDataModel characterDataModel)
        {
            _characterDataModel = characterDataModel;
        }

        public void Start()
        {
            Debug.Log($"in character list : {_characterDataModel.CharacterInfoList.Count}");
        }
    }
}