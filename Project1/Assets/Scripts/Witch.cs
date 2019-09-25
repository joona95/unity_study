using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Witch : MonoBehaviour
{
    int HP = 100;
    public GameObject popcorn;
    int frame = 0;

    private void Start()
    {
        //this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    { 
        frame++;
        if (frame >= 30)
        {
            frame = frame - 30;
            Instantiate(popcorn, new Vector3(Random.Range(-2f, 2f), 10f, 0), popcorn.transform.rotation);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * 0.04f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * 0.04f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        HP = HP - 20;
        Destroy(collision.gameObject);
        StartCoroutine("ChangeColor");
        if (HP == 0)
            Destroy(this.gameObject);
    }
    
    IEnumerator ChangeColor()
    {
        
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
        yield return new WaitForSeconds(0.3f);
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);

        Debug.Log("==");
    }
}