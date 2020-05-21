using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week2 : MonoBehaviour
{
    Dictionary<string, string> Rankdict = new Dictionary<string, string>();
    string level = "0";
    // Start is called before the first frame update
    void Start()
    {
        Rankdict.Add("0", "브론즈1");
        Rankdict.Add("1", "브론즈2");
        Rankdict.Add("2", "브론즈3");
        Rankdict.Add("3", "실버");
        Rankdict.Add("4", "골드");
        Rankdict.Add("5", "플래티넘");

        Debug.Log("고블린의 레벨은 " + level + ", 등급은 " + Rankdict[level]);

        //List <Dictionary<string. object>> data = CSVReader.Read("파일명"); hp = data[0]["HP"];

    }

    // Update is called once per frame
    void Update()
    {
        /*
        int[,] array= new int[3,3];
        for (int i = 1; i <= 3; i++)
        {
            for(int j = 1; j <= 3; j++)
            {
                array[i - 1, j - 1] = (i-1)*3 + j;
            }
        }*/

        //델리게이트: 같은 함수 반환형을 가진 함수들만 가능. 함수 포인터 링크드리스트라고 생각.

    }
}
