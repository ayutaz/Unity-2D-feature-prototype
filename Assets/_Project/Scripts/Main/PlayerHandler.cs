using UnityEngine;

namespace _Project.Main
{
    public class PlayerHandler : MonoBehaviour
    {
        private SpriteRenderer _spriteRenderer;

        private void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        public void SetColor(string color)
        {
            if (ColorUtility.TryParseHtmlString(color, out var colorValue))
            {
                _spriteRenderer.color = colorValue;
            }
            else
            {
                Debug.Log("Invalid color: " + color);
            }
        }

        public void UpdatePlayerPosition(Vector2 vector2)
        {
            transform.transform.Translate(vector2 * Time.deltaTime);
        }
    }
}