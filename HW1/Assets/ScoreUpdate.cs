using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //

public class ScoreUpdate : MonoBehaviour
{
    public int frame = 0;
    private void Awake()
    {
        if (PlayerPrefs.HasKey("highscore"))
        {
            this.gameObject.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt("highscore").ToString();
        }
        else
        {
            this.gameObject.GetComponent<TextMeshProUGUI>().text = "0";
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*
        frame++;
        this.gameObject.GetComponent<TextMeshProUGUI>().text = frame.ToString();
        */
    }
}
