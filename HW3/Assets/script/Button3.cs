using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Button3 : MonoBehaviour
{
    public GameObject num, num1, num2;

    public void onButtonClick()
    {
        if (num.GetComponent<RandomNum>().first == false)
        {
            num.GetComponent<RandomNum>().firstNum = 3;
            num.GetComponent<RandomNum>().first = true;
            num1.GetComponent<TextMeshProUGUI>().text = num.GetComponent<RandomNum>().firstNum.ToString();
        }
        else
        {
            if (num.GetComponent<RandomNum>().second == false)
            {
                num.GetComponent<RandomNum>().secNum = 3;
                num.GetComponent<RandomNum>().second = true;
                num2.GetComponent<TextMeshProUGUI>().text = num.GetComponent<RandomNum>().secNum.ToString();
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
