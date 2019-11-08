using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (player.gameObject != null)
        {
            if (player.transform.position.y <= 1f)
            {
                transform.position = new Vector3(0f, player.transform.position.y, -10f);
            }
            else
            {
                transform.position = new Vector3(0f, 1f, -10f);
            }
        }
    }
}
