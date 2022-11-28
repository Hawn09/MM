using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SenSor : MonoBehaviour
{
<<<<<<< Updated upstream
    
=======

    public bool find = false;
    public float Speed = 0.01f;
    float forward = 1f;
    float time = 0.0f;
    public Transform parent;

>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======

            findpeng = Instantiate(prefab, parent);


>>>>>>> Stashed changes
        }

    }
    void FixedUpdate()
    {
<<<<<<< Updated upstream
        
        
=======
        if (find == false)
        {
            transform.position += new Vector3(forward * Speed, 0, 0);
            if (transform.position.x > 9)
            {
                forward = -1;

            }
            else if (transform.position.x < -9)
            {
                forward = 1;

            }
        }

>>>>>>> Stashed changes
    }
}
