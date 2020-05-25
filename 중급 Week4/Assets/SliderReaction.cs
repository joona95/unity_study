using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class SliderReaction : MonoBehaviour
{
    public Slider mySlider;
    public UnityEvent ui;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        GetComponent<Slider>().onValueChanged.AddListener(delegate
        {
            if (GetComponent<Slider>().value == 5)
            {
                Debug.Log("Five Stars");
            }
        });

        /*
         delegate(float arg0){
         }
         */
    }
    
    public void DoSomething()
    {
        Debug.Log("");
    }
    

    
}
