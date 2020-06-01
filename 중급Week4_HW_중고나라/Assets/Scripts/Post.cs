using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Post : MonoBehaviour, IPointerDownHandler
{
    public string itemname;
    public int price;
    public GameObject black;
    public GameObject Buy_UI;
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
        PlayerPrefs.SetString("Buy_Name", itemname);
        PlayerPrefs.SetInt("Buy_Price", price);
        black.SetActive(true);
        Buy_UI.SetActive(true);
    }
}
