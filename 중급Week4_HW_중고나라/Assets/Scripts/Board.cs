using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Board : MonoBehaviour
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

    public GameObject Refresh;
    public GameObject[] Posts = new GameObject[6];
    List<Item_Info> itemlist = new List<Item_Info>();

    // Start is called before the first frame update
    void Start()
    {

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


        makeRandomPost();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void makeRandomPost()
    {
        bool[] check = new bool[11];

        for(int i = 0; i < 11; i++)
        {
            if (PlayerPrefs.GetInt("has" + i.ToString())==1)
            {
                check[i] = true;
            }
            else
            {
                check[i] = false;
            }
        }

        int idx = 0, c=0;
        while (idx < 6 && c<100)
        {
            int num = Random.Range(0, 11);

            if (check[num] == false)
            {
                Posts[idx].SetActive(true);
                string front="";
                string end="";
                int n;
                switch (num)
                {
                    //건물
                    case 0:
                    case 5:
                        n = Random.Range(0, 2);
                        if (n == 0)
                        {
                            front = "역세권 ";
                            end = "겨우 " + itemlist[num].price.ToString() + "만원!";
                            
                        }
                        else
                        {
                            front = "햇빛 잘드는 남향 ";
                            end = " 나왔습니다 ^^";
                            
                        }
                        break;
                    //과일
                    case 1:
                    case 7:
                    case 10:
                        n = Random.Range(0, 2);
                        if (n == 0)
                        {
                            front = "직접 재배한 ";
                            end = ". 품질 보장.";
                        }
                        else
                        {
                            front = "국내산 ";
                            end = " 팝니다.";
                        }

                        break;
                    //의류
                    case 2:
                    case 3:
                    case 9:
                        n = Random.Range(0, 2);
                        if (n == 0)
                        {
                            front = "[초특가] ";
                            end = " 단돈 "+itemlist[num].price.ToString()+"만원";
                        }
                        else
                        {
                            front = "(새상품) ";
                            end = " 싸게 팔아요";
                        }
                        break;
                    //물건가구
                    case 4:
                    case 6:
                    case 8:
                        n = Random.Range(0, 2);
                        if (n == 0)
                        {
                            front = "사용감 조금 있는 ";
                            end = " 급처합니다";
                        }
                        else 
                        {
                            front = "최신 ";
                            end = " 팝니다 :)";
                        }
                        break;
                }

                Posts[idx].GetComponent<Transform>().GetChild(0).GetComponent<Text>().text = front+itemlist[num].itemname.ToString() + end;
                Posts[idx].GetComponent<Post>().itemname = itemlist[num].itemname;
                Posts[idx].GetComponent<Post>().price = itemlist[num].price;

                check[num] = true;
                idx++;
            }

            int count = 0;
            for(int i = 0; i < 11; i++)
            {
                if (check[i] == true)
                {
                    count++;
                }
            }

            if (count == 11)
                break;

            c++;
        }
    }


    public void onClickRefresh()
    {

    }
}
