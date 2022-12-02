using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SenSor : MonoBehaviour
{

    public bool find = false;
    public float Speed = 0.01f;
    float forward = 1f;
    float time = 0.0f;
    public Transform parent;

    public bool detect = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= 5)
        {
            Destroy(gameObject);

            Debug.Log("Destroyed");
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "GwangMul")
        {
            detect = true;
            Debug.Log("detect =" + detect);

            findpeng = Instantiate(prefab, parent);
            Speed = 0f;


        }

    }
    public GameObject prefab;
    GameObject findpeng;
    void FixedUpdate()
    {
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

    }
}
