using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float pre_dist;
    // Start is called before the first frame update
    void Start()
    {
        pre_dist = -7f;
    }

    // Update is called once per frame
    void Update()
    {
        float dist = this.gameObject.transform.position.x;
        GameManager.score += (dist - pre_dist);
        pre_dist = dist;

        if (this.gameObject.transform.position.y < -5f)
        {
            GameManager.fail = true;
        }

        if (Input.GetKey(KeyCode.Space)&&this.gameObject.transform.position.y<3f)
        {
            //transform.Translate(new Vector3(0.5f,1,0) * 20 * Time.deltaTime, Space.World);
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0.05f, 1f,0) * 3, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "jump_left")
        {
            //transform.Translate(new Vector3(-0.5f, 1, 0) * 50 * Time.deltaTime, Space.World);
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(-1f, 0.5f, 0) * 3, ForceMode2D.Impulse);
        }
        else if (collision.gameObject.name == "jump_right")
        {
            //transform.Translate(new Vector3(0.5f, 1, 0) * 50 * Time.deltaTime, Space.World);
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(1f, 0.5f, 0) * 3, ForceMode2D.Impulse);
        }
    }
}
