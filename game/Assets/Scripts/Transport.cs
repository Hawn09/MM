using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Transport : MonoBehaviour
{
    public float Speed = 0.01f;
    float forward = 1f;
    SpriteRenderer rend;

    private void Awake()
    {
        GameObject[] go = GameObject.FindGameObjectsWithTag("MinePlane");

        if (go != null)
        {
            Debug.Log("Ã£À½");
        }
    }

    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }


    void FixedUpdate()
    {
        transform.position += new Vector3(forward * Speed, 0, 0);
        if (transform.position.x > 9 )
        {
            forward = -1;
            rend.flipX = true;
        }
        else if (transform.position.x < -9)
        {
            forward = 1;
            rend.flipX = false;
        }
    }

    void goAwake()
    {
        Invoke("Awake", 2);
    }
  

    //void getMove()
    //{
    //    if (transform.position.x > go.transform.position.x)
    //    {
    //        forward = -1;
    //        rend.flipX = true;
    //    }
    //    else if (transform.position.x < go.transform.position.x)
    //    {
    //        forward = 1;
    //    }
    //    else (transform.position.x == go.transform.position.x)forward = 0;
    //}
}
