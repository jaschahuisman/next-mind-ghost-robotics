using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;


public class API_Controller : MonoBehaviour
{
    public string IP = "http://127.0.0.1";
    public int PORT = 1234;

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

    public IEnumerator Test()
    {
        using (UnityWebRequest request = UnityWebRequest.Get(IP + ":" + PORT))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError) { Debug.Log(request.error); }
        }
    }

    public IEnumerator Sit()
    {
        using (UnityWebRequest request = UnityWebRequest.Get(IP + ":" + PORT + "/sit"))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError) { Debug.Log(request.error); }
        }
    }

    public IEnumerator Stand()
    {
        using (UnityWebRequest request = UnityWebRequest.Get(IP + ":" + PORT + "/stand"))
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
