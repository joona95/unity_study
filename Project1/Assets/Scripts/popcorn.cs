using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popcorn : MonoBehaviour
{
    void Update()
    {
        if (this.gameObject.transform.position.y <= -10) { Destroy(this.gameObject); }
    }
}
