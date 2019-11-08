using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    int Life = 3;
    public GameObject popcorn;
    float nextTime = 0;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nextTime >= 10)
        {
            Instantiate(popcorn, new Vector3(0, 4, 0), popcorn.transform.rotation);
            nextTime = 0;
        }
        else
        {
            nextTime += Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Life--;
        if (Life <= 0)
        {
            if (PlayerPrefs.HasKey("highscore"))
            {
                int highsc = PlayerPrefs.GetInt("highscore");
                if(highsc < score)
                {
                    PlayerPrefs.SetInt("highscore", score);
                }
            }
            else
            {
                PlayerPrefs.SetInt("highscore", score);
            }
            Debug.Log(score);
            Time.timeScale = 0f;
        }
    }
}
