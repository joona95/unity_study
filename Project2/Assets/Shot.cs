using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    float frame = 0;
    float degree = 0;
    public GameObject ball;
    public GameObject NormalMouse, AngryMouse;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            degree += 15;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            degree -= 15;
        }

        this.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, degree);

        frame++;


        //90초(5400)프레임 게임 중단
        if (frame >= 5400)
        {
            Time.timeScale = 0f;
        }
        else
        {

            //ball 생성
            if (frame % 15 == 0)
            {
                GameObject b = (GameObject)Instantiate(ball, this.gameObject.transform.position, this.gameObject.transform.rotation);
                //Quaternion q = this.gameObject.transform.rotation;
                //b.GetComponent<Ball>().ballvector = new Quaternion(q.x, q.y, q.z, q.w);
                Debug.Log(this.gameObject.transform.rotation);

                Debug.Log("make ball\n");
            }

            //mouse 생성

            if (frame < 3600)
            {
                if (frame % 120 == 0)
                {
                    Instantiate(NormalMouse, new Vector3(12f, -1.5f), new Quaternion(0f, 0f, 0f, 0f));

                    Debug.Log("make normal mouse\n");
                }


            }
            else
            {
                if (frame % 120 == 0)
                {
                    Instantiate(AngryMouse, new Vector3(12f, -1.5f), new Quaternion(0f, 0f, 0f, 0f));

                    Debug.Log("make angry mouse\n");
                }

            }

        }
    }
}
