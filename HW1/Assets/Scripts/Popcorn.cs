using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popcorn : MonoBehaviour
{
    public GameObject Manager;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  

    }

    
    private void OnMouseDown()
    {
        Debug.Log("touch");
        this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(Random.Range(-1f,1f),1,0) * 5f, ForceMode2D.Impulse);
        Manager.GetComponent<manager>().score += 1;
    }
    
}
