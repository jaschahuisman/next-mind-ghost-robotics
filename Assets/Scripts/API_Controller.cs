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

    void Sit()
    {
        string uri = URI + "/sit";
        using (UnityWebRequest request = UnityWebRequest.Get(uri))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
            {
                Debug.log("Network/http error: " + request);
            }
        }
    }
}
