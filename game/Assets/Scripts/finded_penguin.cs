using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finded_penguin : MonoBehaviour
{
    
    void Start()
    {
    
    }

    float time = 0.0f;

    
    void Update()
    {
        time += Time.deltaTime;

        if (time >= 1)
        {
            Destroy(gameObject);
            
            Debug.Log("Destroyed");
        }
    }
}
