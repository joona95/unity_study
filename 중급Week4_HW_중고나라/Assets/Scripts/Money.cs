using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Money : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("money"))
        {
            PlayerPrefs.SetInt("money", 10);

        }


        int money = PlayerPrefs.GetInt("money");
        if (SceneManager.GetActiveScene().name == "Talk")
        {
            this.gameObject.GetComponent<Text>().text = money.ToString() + "만원";
        }
        else
        {
            this.gameObject.GetComponent<Text>().text = "잔고: " + money.ToString() + "만원";
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
