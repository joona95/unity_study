using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //float frame = 0;
    //public Quaternion ballvector;

    private void Awake()
    {
        Debug.Log(this.gameObject.transform.rotation);
        this.gameObject.GetComponent<Rigidbody2D>().AddForce(this.gameObject.transform.rotation*Vector2.up * 13, ForceMode2D.Impulse);
    }

    void Update()
    {
        if (this.gameObject.GetComponent<Transform>().position.y < -10)
        {
            Destroy(this.gameObject);
        }
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name=="회색쥐_0(Clone)" || collision.gameObject.name == "화난쥐_0(Clone)")
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-1f, 1f), 1) * 10, ForceMode2D.Impulse);
            StartCoroutine("Fade");
        }
    }

    IEnumerator Fade()
    {
        for (float i = 1f; i >= 0; i -= 0.1f)
        {
            Color color = new Color(1, 1, 1, i);
            this.gameObject.GetComponent<SpriteRenderer>().material.color = color;
            yield return null;
        }

        Destroy(this.gameObject);
    }
}
