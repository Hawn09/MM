using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        Debug.Log("Button Clicked");

    }
    public void ToPeng()
    {
        Spawn.spawnnum = 1;
    }
    public void Torail()
    {
        Spawn.spawnnum = 2;
    }
    public void Totonglo()
    {
        Spawn.spawnnum = 3;
    }
}
