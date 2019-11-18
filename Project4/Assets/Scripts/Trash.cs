using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    //public GameObject Manage;
    bool move = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (move == true)
        {
            float speed = Time.deltaTime * 2;
            Person.Manage.Obj.transform.Translate(this.gameObject.transform.position * speed);
            Debug.Log("trash");
        }
    }
    private void OnMouseDown()
    {
        move = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        move = false;
        Transform tr = Person.Manage.Obj.transform.GetChild(0);
        GameObject top = tr.gameObject;
        Debug.Log(top.name);
        Debug.Log("trash collision");
        if (!top.name.Equals("Pine(Clone)"))
        {
            Person.Manage.life--;
            Debug.Log(Person.Manage.life);
        }
        Destroy(collision.gameObject); 
        //StartCoroutine("newPizza");
    }

    IEnumerator newPizza()
    {
        yield return new WaitForSeconds(0.2f);
        Person.Manage.createPizza();
    }
}
