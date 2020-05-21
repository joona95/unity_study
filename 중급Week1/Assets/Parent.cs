using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        MyComponent[] children = this.gameObject.GetComponentsInChildren<MyComponent>();
        foreach (MyComponent m in children)
        {
            m.SayMyName();
        }*/
        BroadcastMessage("SayMyName");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
