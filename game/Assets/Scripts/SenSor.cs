using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SenSor : MonoBehaviour
{
    
    public bool detect = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 
    
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "GwangMul")
        {
            detect = true;
            Debug.Log("detect =" + detect);
        }
        
    }
    void FixedUpdate()
    {
        
        
    }
}

