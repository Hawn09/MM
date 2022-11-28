using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penguin : MonoBehaviour
{
    public bool find = false;
    public float Speed = 0.01f;
    float forward = 1f;
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
<<<<<<< HEAD
            
            if (transform.position.x > 9)
            {
                
=======
            transform.position += new Vector3(forward * Speed, 0, 0);
            if (transform.position.x > 9)
            {
                forward = -1;
>>>>>>> d4a75677150a1011756151ed2bef498b6ab1e8a9
                rend.flipX = true;
            }
            else if (transform.position.x < -9)
            {
<<<<<<< HEAD
                
=======
                forward = 1;
>>>>>>> d4a75677150a1011756151ed2bef498b6ab1e8a9
                rend.flipX = false;
            }
        } 
        
        
    }
    public void pengguinmove()
    {
        
    }

}  