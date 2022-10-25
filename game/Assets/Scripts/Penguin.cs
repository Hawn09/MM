using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penguin : MonoBehaviour
{

    public float Speed = 0.01f;
    float forward = 1f;
    SpriteRenderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame
    void Update()
    {


    }

    void FixedUpdate()
    {
        transform.position += new Vector3(forward * Speed, 0, 0);
        if (transform.position.x > 9){
            forward = -1;
            rend.flipX = true;
        }
        else if (transform.position.x < -9)
        {
            forward = 1;
            rend.flipX = false;
        }
    }

}  