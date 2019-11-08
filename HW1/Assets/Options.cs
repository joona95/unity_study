using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    public bool option = false;

    public void optionClick()
    {
        if (option == false)
        {
            option = true;
            Time.timeScale = 0f;
        }
        else
        {
            option = false;
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
