using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomouse : MonoBehaviour
{
    Vector3 mousePos, transPos, targetPos;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            CalTargetPos();
        

        SpawnToTarget();
    }

    void CalTargetPos()
    {
        mousePos = Input.mousePosition;
        transPos = Camera.main.ScreenToWorldPoint(mousePos);
        targetPos = new Vector3(transPos.x, transPos.y, 0);
    }

    void SpawnToTarget()
    {
        transform.position = targetPos;
    }
}
