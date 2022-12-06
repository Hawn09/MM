using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penguin : MonoBehaviour
{
    public bool find = false;
    public float Speed = 0.01f;
    
    SpriteRenderer rend;
    float timer;


    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        //GameObject child = transform.Find("Sensor").gameObject;

    }


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;


    }

    void FixedUpdate()
    {
        if (find == false)
        {


            if (transform.position.x > 9)
            {
                

                rend.flipX = true;
            }
            else if (transform.position.x < -9)
            {


                

                rend.flipX = false;
            }

        }

    }
}