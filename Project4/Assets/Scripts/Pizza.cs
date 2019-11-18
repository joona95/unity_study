using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : MonoBehaviour
{
    public float x, z;
    // Start is called before the first frame update
    void Start()
    {
        x = this.gameObject.transform.position.x;
        z = this.gameObject.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        
        float speed = Time.deltaTime * 0.5f;
        this.gameObject.transform.Translate(new Vector3(x, -3, z)*speed);
    }
    
}
