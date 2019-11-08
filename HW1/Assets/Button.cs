using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    bool isStopped = false;

    public void buttonClick()
    {
        if (isStopped == false)
        {
            isStopped = true;
            Time.timeScale = 0f;
        }
        else
        {
            isStopped = false;
            Time.timeScale = 1f;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
