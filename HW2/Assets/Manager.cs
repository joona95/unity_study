using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject ddung, coin, player;
    int frame;

    void Awake()
    {
        Instantiate(ddung, new Vector3(Random.Range(-2f, 2f), Random.Range(-2f, 5f)), this.gameObject.transform.rotation);
        Instantiate(coin, new Vector3(Random.Range(-2f, 2f), Random.Range(-2f, 5f)), this.gameObject.transform.rotation);
    }

    

    // Update is called once per frame
    void Update()
    {
        if (player.gameObject == null)
        {
            Time.timeScale = 0f;
        }
        else
        {
            frame++;

            if (frame >= 100)
            {
                Instantiate(ddung, new Vector3(Random.Range(-2f, 2f), Random.Range(-2f, 5f)), this.gameObject.transform.rotation);
                Instantiate(coin, new Vector3(Random.Range(-2f, 2f), Random.Range(-2f, 5f)), this.gameObject.transform.rotation);
                frame -= 100;
            }
        }
    }
}
