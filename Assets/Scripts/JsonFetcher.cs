using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class JsonFetcher : MonoBehaviour
{
    private string url = "https://api.jsonbin.io/v3/b/6686a992e41b4d34e40d06fa";

    void Start()
    {
        StartCoroutine(GetJson());
    }

    IEnumerator GetJson()
    {
        UnityWebRequest request = UnityWebRequest.Get(url);
        yield return request.SendWebRequest();

        if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.LogError(request.error);
        }
        else
        {
            string json = request.downloadHandler.text;
            Debug.Log(json);
            PlayerData playerData = JsonUtility.FromJson<PlayerData>(json);
            DisplayPlayerData.Instance.DisplayData(playerData);
        }
    }
}
