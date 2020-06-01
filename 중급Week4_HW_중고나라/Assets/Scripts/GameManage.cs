using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManage : MonoBehaviour
{
    public class Item_Info
    {
        public string itemname;
        public int price;

        public Item_Info(string _name, int _price)
        {
            itemname = _name;
            price = _price;
        }
    }

    public GameObject Percent_text;
    public GameObject Percent;
    public GameObject[] items = new GameObject[11];
    public GameObject[] locks = new GameObject[11];
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("lock0"))
        {
            PlayerPrefs.SetInt("lock0", 1);
        }
        if (!PlayerPrefs.HasKey("lock1"))
        {
            PlayerPrefs.SetInt("lock1", 1);
        }
        if (!PlayerPrefs.HasKey("lock2"))
        {
            PlayerPrefs.SetInt("lock2", 1);
        }
        if (!PlayerPrefs.HasKey("lock3"))
        {
            PlayerPrefs.SetInt("lock3", 1);
        }
        if (!PlayerPrefs.HasKey("lock4"))
        {
            PlayerPrefs.SetInt("lock4", 1);
        }
        if (!PlayerPrefs.HasKey("lock5"))
        {
            PlayerPrefs.SetInt("lock5", 1);
        }
        if (!PlayerPrefs.HasKey("lock6"))
        {
            PlayerPrefs.SetInt("lock6", 1);
        }
        if (!PlayerPrefs.HasKey("lock7"))
        {
            PlayerPrefs.SetInt("lock7", 1);
        }
        if (!PlayerPrefs.HasKey("lock8"))
        {
            PlayerPrefs.SetInt("lock8", 1);
        }
        if (!PlayerPrefs.HasKey("lock9"))
        {
            PlayerPrefs.SetInt("lock9", 1);
        }
        if (!PlayerPrefs.HasKey("lock10"))
        {
            PlayerPrefs.SetInt("lock10", 1);
        }


        if (!PlayerPrefs.HasKey("has0"))
        {
            PlayerPrefs.SetInt("has0", 0);
        }
        if (!PlayerPrefs.HasKey("has1"))
        {
            PlayerPrefs.SetInt("has1", 0);
        }
        if (!PlayerPrefs.HasKey("has2"))
        {
            PlayerPrefs.SetInt("has2", 0);
        }
        if (!PlayerPrefs.HasKey("has3"))
        {
            PlayerPrefs.SetInt("has3", 0);
        }
        if (!PlayerPrefs.HasKey("has4"))
        {
            PlayerPrefs.SetInt("has4", 0);
        }
        if (!PlayerPrefs.HasKey("has5"))
        {
            PlayerPrefs.SetInt("has5", 0);
        }
        if (!PlayerPrefs.HasKey("has6"))
        {
            PlayerPrefs.SetInt("has6", 0);
        }
        if (!PlayerPrefs.HasKey("has7"))
        {
            PlayerPrefs.SetInt("has7", 0);
        }
        if (!PlayerPrefs.HasKey("has8"))
        {
            PlayerPrefs.SetInt("has8", 0);
        }
        if (!PlayerPrefs.HasKey("has9"))
        {
            PlayerPrefs.SetInt("has9", 0);
        }
        if (!PlayerPrefs.HasKey("has10"))
        {
            PlayerPrefs.SetInt("has10", 0);
        }


        List<Item_Info> itemlist = new List<Item_Info>();
        itemlist.Add(new Item_Info("아파트", 9999));
        itemlist.Add(new Item_Info("사과", 10));
        itemlist.Add(new Item_Info("원피스", 150));
        itemlist.Add(new Item_Info("모자", 25));
        itemlist.Add(new Item_Info("노트북", 500));
        itemlist.Add(new Item_Info("원룸", 80));
        itemlist.Add(new Item_Info("피아노", 4500));
        itemlist.Add(new Item_Info("감자", 5));
        itemlist.Add(new Item_Info("냉장고", 1000));
        itemlist.Add(new Item_Info("신발", 50));
        itemlist.Add(new Item_Info("토마토", 7));



        int count = 0;

        for(int i = 0; i < 11; i++)
        {
            if (PlayerPrefs.GetInt("lock" + i.ToString())==0)
            {
                locks[i].SetActive(false);
                items[i].GetComponent<Item>().Lock = false;
            }
            else
            {
                items[i].GetComponent<Item>().Lock = true;
            }

            if (PlayerPrefs.GetInt("has" + i.ToString()) == 0)
            {
                Color col = new Color(1f, 1f, 1f, 0.5f);
                items[i].GetComponent<Image>().color = col;
                items[i].GetComponent<Item>().has = false;
            }
            else
            {
                items[i].GetComponent<Item>().has = true;
                count++;
            }

            items[i].GetComponent<Item>().itemname = itemlist[i].itemname;
            items[i].GetComponent<Item>().price = itemlist[i].price;
        }

        float result = count / 11f;
        Percent_text.GetComponent<Text>().text = "수집률 " + ((int)(result*100)).ToString() + "%";
        Percent.GetComponent<Image>().fillAmount = result;

    }

    // Update is called once per frame
    void Update()
    {
    }
}
