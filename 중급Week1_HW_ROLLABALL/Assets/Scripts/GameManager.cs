using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    static public bool fail = false;
    public GameObject ball;
    public GameObject Map;
    public GameObject black;
    public TextMeshProUGUI count_text;
    public TextMeshProUGUI gameover_text;
    public TextMeshProUGUI gameoverhigh_text;
    public TextMeshProUGUI Second;
    public TextMeshProUGUI Highscore;

    bool start=false;
    float time;
    static public float score;
    float highscore;
    // Start is called before the first frame update
    void Start()
    {
        score = 0f;
        time = 60f;
        Time.timeScale = 1f;
        ball.GetComponent<Ball>().enabled = false;
        Map.GetComponent<Map>().enabled = false;
        StartCoroutine("Count");

        if (!PlayerPrefs.HasKey("highscore"))
        {
            PlayerPrefs.SetFloat("highscore", 0f);
        }
        else
        {
            highscore = PlayerPrefs.GetFloat("highscore");
            Highscore.text = highscore.ToString() + " m";
        }
    }

    IEnumerator Count()
    {
        for(int i = 3; i > 0; i--)
        {
            count_text.text = i.ToString();
            yield return new WaitForSeconds(1);
        }

        black.SetActive(false);
        count_text.gameObject.SetActive(false);
        Map.GetComponent<Map>().enabled = true;
        ball.GetComponent<Ball>().enabled = true;
        start = true;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(score);

        if (start == true)
        {
            time -= Time.deltaTime;
            time = Mathf.Round(time * 100) * 0.01f;
            Second.text = time.ToString() + " s";
        }

        if (fail == true || time <=0f)
        {
            if(time<=0f)
                Second.text = "0.00 s";
            Time.timeScale = 0f;
            ball.GetComponent<Ball>().enabled = false;
            Map.GetComponent<Map>().enabled = false;
            black.SetActive(true);
            gameover_text.gameObject.SetActive(true);
            if (highscore < score)
            {
                PlayerPrefs.SetFloat("highscore", Mathf.Round(score*100f)*0.01f);
            }
            gameoverhigh_text.gameObject.SetActive(true);
            float high = PlayerPrefs.GetFloat("highscore");
            gameoverhigh_text.text = "High Score: " + high.ToString() +" m";
        }
    }
}
