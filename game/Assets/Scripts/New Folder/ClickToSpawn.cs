using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToSpawn : MonoBehaviour
{
    public GameObject Penguin;
    public GameObject rail;
    public GameObject tonglo;

    Vector2 mPos;
    Camera Camera;
    // Start is called before the first frame update
    void Start()
    {
        Camera = GameObject.Find("Main_Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    /*void Update()
    {
        mPos = Input.mousePosition;
        mPos = Camera.ScreenToWorldPoint(mPos);

        transform.position = mPos;
        
        if(Input.GetMouseButtonDown(0))
        {
            GameObject gameObject = Instantiate(Penguin) as GameObject;
            gameObject.transform.position = mPos;
        }
    }*/
    void Update()
    {
        mPos = Input.mousePosition;
        mPos = Camera.ScreenToWorldPoint(mPos);

        transform.position = mPos;

        if (Input.GetMouseButtonDown(0))
        {
            GameObject gameObject = Instantiate(Penguin) as GameObject;
            gameObject.transform.position = mPos;
        }
    }
}
