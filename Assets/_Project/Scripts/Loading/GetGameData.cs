using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace _Project.Loading
{
    public class GetGameData
    {
        public static async UniTask<T> GetGameInfo<T>(string url, string sheetName)
        {
            var request = UnityWebRequest.Get($"{url}?sheetName={sheetName}");
            await request.SendWebRequest();
            if (request.result is UnityWebRequest.Result.ConnectionError or UnityWebRequest.Result.ProtocolError or UnityWebRequest.Result.DataProcessingError)
            {
                Debug.Log("fail to get card info from google sheet");
            }
            else
            {
                var json = request.downloadHandler.text;
                var data = JsonUtility.FromJson<T>(json);
                return data;
            }

            return default;
        }
    }
}