using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public static int spawnnum;
    public GameObject peng;
    public GameObject rail;
    public GameObject tonglo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnnum==1)
        {
            Vector3 mPos3D = Input.mousePosition;
            mPos3D.z = Camera.main.transform.position.z + 20;

            Vector3 mPos2D = Camera.main.ScreenToWorldPoint(mPos3D);
            mPos2D.y = 0;


            if (Input.GetMouseButtonDown(0))
            {
                GameObject gameObject = Instantiate(peng) as GameObject;
                gameObject.transform.position = mPos2D;
                spawnnum = 0;
            }
        }
        else if (spawnnum == 2)
        {
            Vector3 mPos3D = Input.mousePosition;
            mPos3D.z = Camera.main.transform.position.z + 20;

            Vector3 mPos2D = Camera.main.ScreenToWorldPoint(mPos3D);
            


            if (Input.GetMouseButtonDown(0))
            {
                GameObject gameObject = Instantiate(rail) as GameObject;
                gameObject.transform.position = mPos2D;
                spawnnum = 0;
            }
        }
        else if(spawnnum == 3)
        {
            Vector3 mPos3D = Input.mousePosition;
            mPos3D.z = Camera.main.transform.position.z + 20;

            Vector3 mPos2D = Camera.main.ScreenToWorldPoint(mPos3D);
            


            if (Input.GetMouseButtonDown(0))
            {
                GameObject gameObject = Instantiate(tonglo) as GameObject;
                gameObject.transform.position = mPos2D;
                spawnnum = 0;
            }
        }
        else
        {

        }
    }
}
