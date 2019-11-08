using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score < -50)
        {
            Destroy(this.gameObject);
        }

        if (transform.position.x>=-2&&Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * 0.1f);
        }
        else if (transform.position.x <= 2&&Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * 0.1f);
        }
        else if (transform.position.y<=5&&Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * 0.3f);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "팝콘(똥)(Clone)")
        {
            score -= 10;
        }
        else if (collision.gameObject.name == "coin(Clone)")
        {
            score += 1;
        }
        Destroy(collision.gameObject);
        Debug.Log(score);
    }
}
