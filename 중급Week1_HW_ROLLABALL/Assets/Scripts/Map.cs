using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        for(int i = 0; i < this.gameObject.transform.childCount; i++)
        {
            Transform child = this.gameObject.transform.GetChild(i);
            float pos_x = child.position.x;
            float pos_y = child.position.y;
            pos_x -= 0.12f;
            child.position = new Vector3(pos_x, pos_y, 0);
        }
    }
}
