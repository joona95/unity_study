using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomNum : MonoBehaviour
{
    public GameObject Num1, Num2, Score;
    public bool first = false, second = false;
    public int firstNum, secNum;
    public int num1, num2, result, score=0;
    float time = 0f;

    private void Awake()
    {
        num1 = Random.Range(1, 6);
        num2 = Random.Range(1, 6);
        result = num1 * num2;
        this.gameObject.GetComponent<TextMeshProUGUI>().text = result.ToString();

        Screen.SetResolution(1080, 1920, false);
        Screen.fullScreen = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time >= 10f)
        {
            num1 = Random.Range(1, 6);
            num2 = Random.Range(1, 6);
            result = num1 * num2;
            this.gameObject.GetComponent<TextMeshProUGUI>().text = result.ToString();
            Num1.GetComponent<TextMeshProUGUI>().text = "";
            Num2.GetComponent<TextMeshProUGUI>().text = "";
            first = false;
            second = false;
            time = 0f;
        }
        else
        {
            time += Time.deltaTime;
        }

        if (first==true && second == true)
        {
            if (firstNum * secNum == result)
            {
                score += 10;
                Score.GetComponent<TextMeshProUGUI>().text = score.ToString();
            }


            num1 = Random.Range(1, 6);
            num2 = Random.Range(1, 6);
            result = num1 * num2;
            this.gameObject.GetComponent<TextMeshProUGUI>().text = result.ToString();
            Num1.GetComponent<TextMeshProUGUI>().text = "";
            Num2.GetComponent<TextMeshProUGUI>().text = "";
            first = false;
            second = false;
            time = 0f;
        }
 
    }
}
