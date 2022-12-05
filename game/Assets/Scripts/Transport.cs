using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transport : MonoBehaviour
{
    public float Speed = 0.01f;
    float forward = 1f;
    SpriteRenderer rend;
    public float location;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }


    void FixedUpdate()
    {
        transform.position += new Vector3(forward * Speed, 0, 0);
        if (transform.position.x > 3)
        {
            forward = -1;
            rend.flipX = true;
        }
        else if (transform.position.x < -3)
        {
            forward = 1;
            rend.flipX = false;
        }

        

    }
}
