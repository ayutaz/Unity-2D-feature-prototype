using UnityEngine;
using VContainer;

namespace _Project.Main
{
    public class MoveHandler : MonoBehaviour
    {
        private InputSystemTest _inputSystemTest;
        [SerializeField] private Transform userObject;

        [Inject]
        private void Construct(InputSystemTest inputSystemTest)
        {
            _inputSystemTest = inputSystemTest;
            _inputSystemTest.Enable();
        }

        private void Start()
        {
            _inputSystemTest.Player.Fire.performed += context => Debug.Log("fire");
        }

        private void Update()
        {
            var direction = _inputSystemTest.Player.Move.ReadValue<Vector2>();
            userObject.Translate(direction * Time.deltaTime);
        }
    }
}