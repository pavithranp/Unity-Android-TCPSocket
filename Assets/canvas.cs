using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class canvas : MonoBehaviour
{
    public GameObject TCPListener;
    public Button connect;
    public Text display;
    public InputField input;
    public static string[] parts;
    public bool pressed;
    // Start is called before the first frame update
    void Start()
    {
        GameObject Listener = GameObject.Find("TCPListener");
        pressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onclick()
    {
        
        string newtext;
        string[] separator = { " ", ":" };
        newtext = input.text;
        parts = newtext.Split(null);
        pressed = true;
        Instantiate(TCPListener);
        Debug.Log("Button Clicked");
    }
    public void onclicknewscene()
    {

        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(1);
        UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(0);
    }
}
