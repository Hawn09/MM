using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rail : MonoBehaviour
{
    float limittime = 20;
    // Use this for initialization 
    void Start()
    {

    }

    float time = 0.0f;

    // Update is called once per frame 
    void Update()
    {
        time += Time.deltaTime;

        if (time >= limittime)
        {
            Destroy(gameObject);
            
            Debug.Log("Destroyed");
        }
    }
}
