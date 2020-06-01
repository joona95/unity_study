using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sell : MonoBehaviour
{
    public GameObject black;
    public GameObject percent_text;
    public GameObject percent;
    public GameObject[] items = new GameObject[11];
    public GameObject ItemName;
    public GameObject ItemPrice;
    public GameObject Sell_UI;
    public GameObject money_text;
    string itemname;
    int price;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        itemname = PlayerPrefs.GetString("Sell_Name");
        price = PlayerPrefs.GetInt("Sell_Price");
        ItemName.GetComponent<Text>().text = itemname;
        ItemPrice.GetComponent<Text>().text = price.ToString() + "만원";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickExitButton()
    {
        black.SetActive(false);
        Sell_UI.SetActive(false);
    }

    public void onClickSellButton()
    {
        int money = PlayerPrefs.GetInt("money");
        money += price;
        PlayerPrefs.SetInt("money", money);
        money_text.GetComponent<Text>().text = "잔고: " + money + "만원";
        
        if (itemname == "아파트")
        {
            PlayerPrefs.SetInt("has0", 0);
            items[0].GetComponent<Item>().has = false;
            Color col = new Color(1f, 1f, 1f, 0.5f);
            items[0].GetComponent<Image>().color = col;
        }
        else if (itemname == "사과")
        {
            PlayerPrefs.SetInt("has1", 0);
            items[1].GetComponent<Item>().has = false;
            Color col = new Color(1f, 1f, 1f, 0.5f);
            items[1].GetComponent<Image>().color = col;
        }
        else if (itemname == "원피스")
        {
            PlayerPrefs.SetInt("has2", 0);
            items[2].GetComponent<Item>().has = false;
            Color col = new Color(1f, 1f, 1f, 0.5f);
            items[2].GetComponent<Image>().color = col;
        }
        else if (itemname == "모자")
        {
            PlayerPrefs.SetInt("has3", 0);
            items[3].GetComponent<Item>().has = false;
            Color col = new Color(1f, 1f, 1f, 0.5f);
            items[3].GetComponent<Image>().color = col;
        }
        else if (itemname == "노트북")
        {
            PlayerPrefs.SetInt("has4", 0);
            items[4].GetComponent<Item>().has = false;
            Color col = new Color(1f, 1f, 1f, 0.5f);
            items[4].GetComponent<Image>().color = col;
        }
        else if (itemname == "원룸")
        {
            PlayerPrefs.SetInt("has5", 0);
            items[5].GetComponent<Item>().has = false;
            Color col = new Color(1f, 1f, 1f, 0.5f);
            items[5].GetComponent<Image>().color = col;
        }
        else if (itemname == "피아노")
        {
            PlayerPrefs.SetInt("has6", 0);
            items[6].GetComponent<Item>().has = false;
            Color col = new Color(1f, 1f, 1f, 0.5f);
            items[6].GetComponent<Image>().color = col;
        }
        else if (itemname == "감자")
        {
            PlayerPrefs.SetInt("has7", 0);
            items[7].GetComponent<Item>().has = false;
            Color col = new Color(1f, 1f, 1f, 0.5f);
            items[7].GetComponent<Image>().color = col;
        }
        else if (itemname == "냉장고")
        {
            PlayerPrefs.SetInt("has8", 0);
            items[8].GetComponent<Item>().has = false;
            Color col = new Color(1f, 1f, 1f, 0.5f);
            items[8].GetComponent<Image>().color = col;
        }
        else if (itemname == "신발")
        {
            PlayerPrefs.SetInt("has9", 0);
            items[9].GetComponent<Item>().has = false;
            Color col = new Color(1f, 1f, 1f, 0.5f);
            items[9].GetComponent<Image>().color = col;
        }
        else if (itemname == "토마토")
        {
            PlayerPrefs.SetInt("has10", 0);
            items[10].GetComponent<Item>().has = false;
            Color col = new Color(1f, 1f, 1f, 0.5f);
            items[10].GetComponent<Image>().color = col;
        }

        int count = 0;
        for(int i = 0; i < 11; i++)
        {
            if (items[i].GetComponent<Item>().has == true)
            {
                count++;
            }
        }

        float result = count / 11f;
        percent.GetComponent<Image>().fillAmount = result;
        percent_text.GetComponent<Text>().text = "수집률 " + (int)(result*100) + "%";
        Debug.Log(count);
        Debug.Log((int)result);

        black.SetActive(false);
        Sell_UI.SetActive(false);
    }
}
