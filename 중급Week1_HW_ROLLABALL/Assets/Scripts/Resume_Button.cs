using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume_Button : MonoBehaviour
{
    public GameObject ball;
    public GameObject Map;
    public GameObject black;
    public GameObject Retry_Button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Resume()
    {
        black.SetActive(false);
        Retry_Button.SetActive(false);
        this.gameObject.SetActive(false);
        Time.timeScale = 1f;
        ball.GetComponent<Ball>().enabled = true;
        Map.GetComponent<Map>().enabled = true;
    }
}
