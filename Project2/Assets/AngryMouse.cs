using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryMouse : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        this.gameObject.GetComponent<Transform>().Translate(new Vector3(-0.3f, 0f));
        
        if (this.gameObject.GetComponent<Transform>().position.x < -12)
        {
            Destroy(this.gameObject);
            Debug.Log("break \n");
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.gameObject.GetComponent<Animator>().SetTrigger("damage");
        //collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-1f, 1f), 1) * 5, ForceMode2D.Impulse);
        //StartCoroutine("Fade");
        //Destroy(collision.gameObject,10*Time.deltaTime);
        //Debug.Log("break ball\n");
    }

    /*
    IEnumerator Fade()
    {
        for (float i = 1f; i >= 0; i -= 0.1f)
        {
            Color color = new Color(1, 1, 1, i);
            c.gameObject.GetComponent<SpriteRenderer>().material.color = color;
            yield return null;
        }

        Destroy(c.gameObject);
    }*/
}
