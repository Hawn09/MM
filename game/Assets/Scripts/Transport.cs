using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transport : MonoBehaviour
{
    public float Speed = 0.01f;
    float forward = 1f;
    SpriteRenderer rend;
    public float location;
    float posx;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        posx = transform.position.x;
    }


    void FixedUpdate()
    {
        transform.position += new Vector3(forward * Speed, 0, 0);
        if(posx > 3)
        {
            if (transform.position.x > posx)
            {
                forward = -1;
                rend.flipX = true;
            }
            else if (transform.position.x < 3)
            {
                forward = 1;
                rend.flipX = false;
            }
        }

        if (posx < 3)
        {
            if (transform.position.x > 3)
            {
                forward = -1;
                rend.flipX = true;
            }
            else if (transform.position.x < posx)
            {
                forward = 1;
                rend.flipX = false;
            }
        }



    }
}
