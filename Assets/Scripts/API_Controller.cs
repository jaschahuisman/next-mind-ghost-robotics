using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;


public class API_Controller : MonoBehaviour
{
    public string IP = "http://127.0.0.1"; // Robothond IP adres
    public int PORT = 1234; // Robothond Port

    public void Trigger(string route)
    {
        switch (route)
        {
            case "sit":
                StartCoroutine(Sit());
                break;
            case "stand":
                StartCoroutine(Stand());
                break;
            case "walk":
                StartCoroutine(Walk());
                break;
            case "walkForward":
                StartCoroutine(WalkForward());
                break;
            default:
                StartCoroutine(Test());
                break;
        }
    }

    // Coroutines om commands te sturen naar de robothond

    public IEnumerator Test()
    {
        using (UnityWebRequest request = UnityWebRequest.Post(IP + ":" + PORT))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError) { Debug.Log(request.error); }
        }
    }

    public IEnumerator Sit()
    {
        using (UnityWebRequest request = UnityWebRequest.Post(IP + ":" + PORT + "/sit"))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError) { Debug.Log(request.error); }
        }
    }

    public IEnumerator Stand()
    {
        using (UnityWebRequest request = UnityWebRequest.Post(IP + ":" + PORT + "/stand"))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError) { Debug.Log(request.error); }
        }
    }

    public IEnumerator Walk()
    {
        using (UnityWebRequest request = UnityWebRequest.Post(IP + ":" + PORT + "/walk", ""))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError) { Debug.Log(request.error); }
        }
    }

    public IEnumerator WalkForward()
    {
        using (UnityWebRequest request = UnityWebRequest.Post(IP + ":" + PORT + "/walkForward", ""))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError) { Debug.Log(request.error); }
        }
    }
}
