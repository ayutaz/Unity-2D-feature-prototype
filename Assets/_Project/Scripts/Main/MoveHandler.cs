using UnityEngine;
using VContainer;

namespace _Project.Main
{
    public class MoveHandler : MonoBehaviour
    {
        private InputSystemTest _inputSystemTest;
        private PlayerInfoList _playerInfoList;
        [SerializeField] private PlayerHandler playerHandler;

        [Inject]
        private void Construct(InputSystemTest inputSystemTest, PlayerInfoList playerInfoList)
        {
            _inputSystemTest = inputSystemTest;
            _playerInfoList = playerInfoList;
            _inputSystemTest.Enable();
        }

        private void Start()
        {
            playerHandler.SetColor(_playerInfoList.gameInfo[0].color);
            _inputSystemTest.Player.Fire.performed += context => Debug.Log("fire");
        }

        private void Update()
        {
            var direction = _inputSystemTest.Player.Move.ReadValue<Vector2>();
            playerHandler.UpdatePlayerPosition(direction * _playerInfoList.gameInfo[0].moveSpeed);
        }
    }
}