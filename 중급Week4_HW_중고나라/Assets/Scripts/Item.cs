using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Item : MonoBehaviour, IPointerDownHandler
{

    public GameObject ItemImage;
    public GameObject black;
    public GameObject Sell_UI;
    public string itemname;
    public int price;
    public bool Lock = true;
    public bool has = false;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (Lock == false && has == true)
        {
            PlayerPrefs.SetString("Sell_Name", itemname);
            PlayerPrefs.SetInt("Sell_Price", price);
            black.SetActive(true);
            Sell_UI.SetActive(true);
            ItemImage.GetComponent<Image>().sprite = this.gameObject.GetComponent<Image>().sprite;
        }
    }
}
