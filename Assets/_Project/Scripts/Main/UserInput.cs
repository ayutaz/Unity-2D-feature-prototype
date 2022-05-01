using UnityEngine;

namespace _Project.Main
{
    public class UserInput : MonoBehaviour
    {
        private InputSystemTest _inputSystemTest;
        [SerializeField] private Transform userObject;

        private void Awake()
        {
            _inputSystemTest = new InputSystemTest();
            _inputSystemTest.Enable();
            _inputSystemTest.Player.Fire.performed += context => Debug.Log("fire");
        }

        private void Update()
        {
            var direction = _inputSystemTest.Player.Move.ReadValue<Vector2>();
            userObject.Translate(direction * Time.deltaTime);
        }
    }
}