using UnityEngine;
using UnityEngine.UI;

namespace _Project.Loading
{
    public class LoadingView : MonoBehaviour
    {
        [SerializeField] private Image progressBar;
        
        public void SetProgress(float progress)
        {
            progressBar.fillAmount = progress;
        }
    }
}