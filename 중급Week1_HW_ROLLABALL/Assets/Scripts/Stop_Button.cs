using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop_Button : MonoBehaviour
{
    public GameObject ball;
    public GameObject Map;
    public GameObject black;
    public GameObject Resume_Button;
    public GameObject Retry_Button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Stop()
    {
        Time.timeScale = 0f;
        ball.GetComponent<Ball>().enabled = false;
        Map.GetComponent<Map>().enabled = false;
        black.SetActive(true);
        Resume_Button.SetActive(true);
        Retry_Button.SetActive(true);       
    }
}
