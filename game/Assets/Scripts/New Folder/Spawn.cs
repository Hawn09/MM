using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mPos3D = Input.mousePosition;
        mPos3D.z = Camera.main.transform.position.z + 20 ;
        
        Vector3 mPos2D = Camera.main.ScreenToWorldPoint(mPos3D);
        mPos2D.y = 0;
        

        if(Input.GetMouseButtonDown(0))
        {
            GameObject gameObject = Instantiate(Prefab) as GameObject;
            gameObject.transform.position = mPos2D;
        }
    }
}
