using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gwangmul : MonoBehaviour
{
    static float gwangmulyang = 100f;
    static float gwangmulminespeed = 1f;
    public GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {

    }

    
    private void OnTriggerStay(Collider collider) //mine
    {
        if (collider.Trigger.name=="Gwangmul")
        {
           
        }
    }
}
