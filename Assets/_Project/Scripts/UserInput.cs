using UnityEngine;

namespace _Project
{
    public class UserInput : MonoBehaviour
    {
        private InputSystemTest _inputSystemTest;

        private void Awake()
        {
            _inputSystemTest = new InputSystemTest();
            _inputSystemTest.Enable();
            _inputSystemTest.Player.Fire.performed += context => Debug.Log("fire");
        }

        private void Update()
        {
            var direction = _inputSystemTest.Player.Move.ReadValue<Vector2>();
            transform.Translate(direction * Time.deltaTime);
        }
    }
}