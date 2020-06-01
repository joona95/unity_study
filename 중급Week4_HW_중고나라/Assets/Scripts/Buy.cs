using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buy : MonoBehaviour
{
    public Sprite[] itemimages = new Sprite[11];
    public GameObject itemImage;
    public GameObject ItemName;
    public GameObject ItemPrice;
    public GameObject black;
    public GameObject Buy_UI;
    string itemname;
    int price;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickExitButton()
    {
        black.SetActive(false);
        Buy_UI.SetActive(false);
    }

    public void OnEnable()
    {
        itemname = PlayerPrefs.GetString("Buy_Name");
        price = PlayerPrefs.GetInt("Buy_Price");


        ItemName.GetComponent<Text>().text = itemname;
        ItemPrice.GetComponent<Text>().text = price.ToString() + "만원";

        if (itemname == "아파트")
        {
            itemImage.GetComponent<Image>().sprite = itemimages[0];
        }
        else if (itemname == "사과")
        {
            itemImage.GetComponent<Image>().sprite = itemimages[1];
        }
        else if (itemname == "원피스")
        {
            itemImage.GetComponent<Image>().sprite = itemimages[2];
        }
        else if (itemname == "모자")
        {
            itemImage.GetComponent<Image>().sprite = itemimages[3];
        }
        else if (itemname == "노트북")
        {
            itemImage.GetComponent<Image>().sprite = itemimages[4];
        }
        else if (itemname == "원룸")
        {
            itemImage.GetComponent<Image>().sprite = itemimages[5];
        }
        else if (itemname == "피아노")
        {
            itemImage.GetComponent<Image>().sprite = itemimages[6];
        }
        else if (itemname == "감자")
        {
            itemImage.GetComponent<Image>().sprite = itemimages[7];
        }
        else if (itemname == "냉장고")
        {
            itemImage.GetComponent<Image>().sprite = itemimages[8];
        }
        else if (itemname == "신발")
        {
            itemImage.GetComponent<Image>().sprite = itemimages[9];
        }
        else if (itemname == "토마토")
        {
            itemImage.GetComponent<Image>().sprite = itemimages[10];

        }
    }

    public void onClickContactButton()
    {
        SceneManager.LoadScene("Talk");
    }
}
