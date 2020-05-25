using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Inventory : MonoBehaviour, IPointerDownHandler
{
    [System.Serializable]
    public class ItemInfo
    {
        public int type;
        public int level;

        public ItemInfo(int _type, int _level)
        {
            type = _type;
            level = _level;
        }
    }

    public GameObject[] inventory = new GameObject[5];
    public List<ItemInfo> items; 
    // Start is called before the first frame update
    void Start()
    {
        items = new List<ItemInfo>();
        items.Add(new ItemInfo(0, 3));
        items.Add(new ItemInfo(1, 2));
        items.Add(new ItemInfo(2, 1));
        items.Add(new ItemInfo(0, 2));
        items.Add(new ItemInfo(1, 3));

        items.Sort((delegate(ItemInfo A, ItemInfo B)
        {
            if(A.level == B.level)
            {
                if (A.type <= B.type)
                    return -1;
                else
                    return 1;
            }
            else 
            {
                if (A.level > B.level)
                    return -1;
                else
                    return 1;
            }
        }));

        int idx = 0;
        foreach(ItemInfo item in items)
        {
            TextMeshProUGUI level_text = inventory[idx].GetComponent<Transform>().GetChild(0).GetComponent<TextMeshProUGUI>();
            level_text.text = item.level.ToString();

            switch (item.type)
            {
                case 0:
                    inventory[idx].GetComponent<Image>().color = new Color(0f, 0f, 0f);
                    break;
                case 1:
                    inventory[idx].GetComponent<Image>().color = new Color(0.5f, 0.5f, 0.5f);
                    break;
                case 2:
                    inventory[idx].GetComponent<Image>().color = new Color(1f, 1f, 1f);
                    break;
            }
            idx++;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }

}
