using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Talk : MonoBehaviour
{
    public Sprite[] itemimages = new Sprite[11];
    public GameObject itemImage;
    public GameObject BuyPrice;
    public GameObject BuyName;
    public GameObject percent;
    public GameObject BuyButton;
    public GameObject DiscountButton;
    public GameObject BackButton;
    public GameObject Input;
    public GameObject Me_Text;
    public GameObject You_Text;
    public GameObject Result;
    public GameObject Result_Text;
    public GameObject Result_Button;
    public GameObject black;
    int count = 5;
    string itemname;
    int discount_price=-1;
    int price;
    int limit;

    // Start is called before the first frame update
    void Start()
    {
        BackButton.SetActive(false);
        itemname = PlayerPrefs.GetString("Buy_Name");
        price = PlayerPrefs.GetInt("Buy_Price");
        BuyName.GetComponent<Text>().text = itemname;
        BuyPrice.GetComponent<Text>().text = price.ToString() + "만원";

        percent.GetComponent<Image>().fillAmount = 1f;
        BuyButton.GetComponent<Button>().interactable = false;

        Me_Text.GetComponent<Text>().text = itemname + " 팔렸나요?";
        You_Text.GetComponent<Text>().text = itemname + " 안팔렸어요.";

        limit = (int)Random.Range(1, price);

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

    // Update is called once per frame
    void Update()
    {
    }

    public void onClickBuy()
    {

        int money = PlayerPrefs.GetInt("money");
        money -= discount_price;
 
        if (money >= 0)
        {
            black.SetActive(true);
            Result.SetActive(true);
            Result_Text.GetComponent<Text>().text = itemname + "를(을) " + discount_price.ToString() + "만원에 샀다!";

            PlayerPrefs.SetInt("money", money);

            if (itemname == "아파트")
            {
                int Lock = PlayerPrefs.GetInt("lock0");
                int has = PlayerPrefs.GetInt("has0");
                if (Lock == 1)
                {
                    PlayerPrefs.SetInt("lock0", 0);
                }

                PlayerPrefs.SetInt("has0", 1);
            }
            else if (itemname == "사과")
            {
                int Lock = PlayerPrefs.GetInt("lock1");
                int has = PlayerPrefs.GetInt("has1");
                if (Lock == 1)
                {
                    PlayerPrefs.SetInt("lock1", 0);
                }

                PlayerPrefs.SetInt("has1", 1);
            }
            else if (itemname == "원피스")
            {
                int Lock = PlayerPrefs.GetInt("lock2");
                int has = PlayerPrefs.GetInt("has2");
                if (Lock == 1)
                {
                    PlayerPrefs.SetInt("lock2", 0);
                }

                PlayerPrefs.SetInt("has2", 1);
            }
            else if (itemname == "모자")
            {
                int Lock = PlayerPrefs.GetInt("lock3");
                int has = PlayerPrefs.GetInt("has3");
                if (Lock == 1)
                {
                    PlayerPrefs.SetInt("lock3", 0);
                }

                PlayerPrefs.SetInt("has3", 1);
            }
            else if (itemname == "노트북")
            {
                int Lock = PlayerPrefs.GetInt("lock4");
                int has = PlayerPrefs.GetInt("has4");
                if (Lock == 1)
                {
                    PlayerPrefs.SetInt("lock4", 0);
                }

                PlayerPrefs.SetInt("has4", 1);
            }
            else if (itemname == "원룸")
            {
                int Lock = PlayerPrefs.GetInt("lock5");
                int has = PlayerPrefs.GetInt("has5");
                if (Lock == 1)
                {
                    PlayerPrefs.SetInt("lock5", 0);
                }

                PlayerPrefs.SetInt("has5", 1);
            }
            else if (itemname == "피아노")
            {
                int Lock = PlayerPrefs.GetInt("lock6");
                int has = PlayerPrefs.GetInt("has6");
                if (Lock == 1)
                {
                    PlayerPrefs.SetInt("lock6", 0);
                }

                PlayerPrefs.SetInt("has6", 1);
            }
            else if (itemname == "감자")
            {
                int Lock = PlayerPrefs.GetInt("lock7");
                int has = PlayerPrefs.GetInt("has7");
                if (Lock == 1)
                {
                    PlayerPrefs.SetInt("lock7", 0);
                }

                PlayerPrefs.SetInt("has7", 1);
            }
            else if (itemname == "냉장고")
            {
                int Lock = PlayerPrefs.GetInt("lock8");
                int has = PlayerPrefs.GetInt("has8");
                if (Lock == 1)
                {
                    PlayerPrefs.SetInt("lock8", 0);
                }

                PlayerPrefs.SetInt("has8", 1);

            }
            else if (itemname == "신발")
            {
                int Lock = PlayerPrefs.GetInt("lock9");
                int has = PlayerPrefs.GetInt("has9");
                if (Lock == 1)
                {
                    PlayerPrefs.SetInt("lock9", 0);
                }

                PlayerPrefs.SetInt("has9", 1);
            }
            else if (itemname == "토마토")
            {
                int Lock = PlayerPrefs.GetInt("lock10");
                int has = PlayerPrefs.GetInt("has10");
                if (Lock == 1)
                {
                    PlayerPrefs.SetInt("lock10", 0);
                }

                PlayerPrefs.SetInt("has10", 1);
            }
        }
        else
        {
            black.SetActive(true);
            Result.SetActive(true);
            Result_Text.GetComponent<Text>().text = "잔고가 부족합니다.";
            Result_Button.GetComponent<Text>().text = "돌아가기";
        }
        
    }

    public void onClickDiscount()
    {
        
        int.TryParse(Input.GetComponent<Text>().text, out discount_price);

        string[] Me = { discount_price.ToString()+"만원 가시죠", discount_price.ToString()+"만원이면 이득아닌가요", "너무너무 갖고싶어요 "+discount_price.ToString()+"만원 안될까요? 제발ㅠㅠ" };
        string[] You_fail = { "이 정도면 충분히 싼데요;", "더이상 얘기나누고 싶지않네요", "다른 데 가서 알아보세요ㅡㅡ" };

        if (limit <= discount_price)
        {
            int num = Random.Range(0, 2);
            if (num == 0) //실패
            {
                count--;
                percent.GetComponent<Image>().fillAmount = count / 5f;
                int n = Random.Range(0, 3);
                Me_Text.GetComponent<Text>().text = Me[n];
                n = Random.Range(0, 3);
                if (count != 0)
                {
                    You_Text.GetComponent<Text>().text = You_fail[n];
                }
                else
                {
                    You_Text.GetComponent<Text>().text = "너한텐 안팔아 차단한다";
                    DiscountButton.SetActive(false);
                    BackButton.SetActive(true);
                }

            }
            else //성공
            {
                DiscountButton.GetComponent<Button>().interactable = false;
                BuyButton.GetComponent<Button>().interactable = true;
                int n = Random.Range(0, 3);
                Me_Text.GetComponent<Text>().text = Me[n];
                n = Random.Range(0, 3);
                You_Text.GetComponent<Text>().text = "알았어요 그냥 " + discount_price.ToString() + "만원에 드릴게요 ㅎㅎ";
            }
        }
        else //실패
        {
            count--;
            percent.GetComponent<Image>().fillAmount = count / 5f;
            int n = Random.Range(0, 3);
            Me_Text.GetComponent<Text>().text = Me[n];
            n = Random.Range(0, 3);
            if (count != 0)
            {
                You_Text.GetComponent<Text>().text = You_fail[n];
            }
            else
            {
                You_Text.GetComponent<Text>().text = "너한텐 안팔아 차단한다";
                DiscountButton.SetActive(false);
                BackButton.SetActive(true);

            }



        }
       
   
    }

 
    public void onClickBack()
    {
        SceneManager.LoadScene("BuySite");
    }


}
