using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    
    public static Person Manage;

    public GameObject Obj;
    public GameObject pizza;
    public GameObject[] topping = new GameObject[7];

    public GameObject end;
    public int idx;
    public int life = 3;
    public GameObject LifeRemain;
    public Sprite[] LifeImage = new Sprite[3];
    bool move = false;


    private void Awake()
    {
        Manage = this;
        StartCoroutine("newPizza");
        //createPizza();
    }
    // Update is called once per frame
    void Update()
    {
        Transform tr = transform.GetChild(0);
        Obj = tr.gameObject;

        switch (life)
        {
            case 2:
                LifeRemain.GetComponent<SpriteRenderer>().sprite = LifeImage[2];
                break;
            case 1:
                LifeRemain.GetComponent<SpriteRenderer>().sprite = LifeImage[1];
                break;
            case 0:
                LifeRemain.GetComponent<SpriteRenderer>().sprite = LifeImage[0];
                break;
        }

        if (life == 0)
        {
            end.SetActive(true);
            Time.timeScale = 0f;        
        }


        if (move == true)
        {
            float speed = Time.deltaTime * 2;
            Obj.transform.Translate(this.gameObject.transform.position * speed);
            Debug.Log("person");
        }

        if (Obj!=null && Obj.GetComponent<Pizza>().x == Obj.transform.position.x && Obj.transform.position.y < -2)
        {
            Destroy(Obj);
            life--;
            Debug.Log(life);
            createPizza();
        }


    }

    
    private void OnMouseDown()
    {
        move = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        move = false;
        Debug.Log("person collision");
        Transform tr = Obj.transform.GetChild(0);
        GameObject top = tr.gameObject;
        Debug.Log(top.name);
        if (top.name.Equals("Pine(Clone)"))
        {
            this.gameObject.GetComponent<Animator>().SetTrigger("bad");
            life--;
            Debug.Log(life);
        }
        else
        {
            this.gameObject.GetComponent<Animator>().SetTrigger("good");
        }
        Destroy(collision.gameObject);  
        //StartCoroutine("newPizza");
    }

    IEnumerator newPizza()
    {
        while (life != 0)
        {            
            createPizza();
            yield return new WaitForSeconds(2f);
        }

    }

    public void createPizza()
    {
        Obj = Instantiate(pizza, new Vector3(0f, 7f, 0f), pizza.gameObject.transform.rotation);
        Obj.transform.parent = this.gameObject.transform;
        idx = Random.Range(0, 7);
        GameObject top = Instantiate(topping[idx], new Vector3(0f, 7f, 0f), topping[idx].gameObject.transform.rotation);
        top.transform.parent = Obj.transform;
    }
}
