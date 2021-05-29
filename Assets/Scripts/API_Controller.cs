using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class API_Controller : MonoBehaviour
{
    public string URI = "http://192.168.168.101";
    public int PORT = 1234;

    // Start is called before the first frame update
    void Start()
    {

    }

    IEnumerator Sit()
    {
        using (UnityWebRequest request = UnityWebRequest.Get(URI + PORT + "/sit"))
        {
            yield return request.SendWebRequest();

            // if (request.isNetworkError)
            // {
            //     // Error
            //     Debug.Log(request.error);
            // }
            // else
            // {
            //     // Success
            //     Debug.Log(request.downloadHandler.text);
            // }
        }
    }
   
    IEnumerator Stand()
    {
        using (UnityWebRequest request = UnityWebRequest.Get(URI + PORT + "/stand"))
        {
            yield return request.SendWebRequest();

            // if (request.isNetworkError)
            // {
            //     // Error
            //     Debug.Log(request.error);
            // }
            // else
            // {
            //     // Success
            //     Debug.Log(request.downloadHandler.text);
            // }
        }
    }
    
    IEnumerator Walk()
    {
        using (UnityWebRequest request = UnityWebRequest.Post(URI + PORT + "/walk", ""))
        {
            yield return request.SendWebRequest();

            // if (request.isNetworkError)
            // {
            //     // Error
            //     Debug.Log(request.error);
            // }
            // else
            // {
            //     // Success
            //     Debug.Log(request.downloadHandler.text);
            // }
        }
    }
    
    IEnumerator WalkForward()
    {
        using (UnityWebRequest request = UnityWebRequest.Post(URI + PORT + "/walkForward", ""))
        {
            yield return request.SendWebRequest();

            // if (request.isNetworkError)
            // {
            //     // Error
            //     Debug.Log(request.error);
            // }
            // else
            // {
            //     // Success
            //     Debug.Log(request.downloadHandler.text);
            // }
        }
    }
}
