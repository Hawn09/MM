using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    
    public static int money;
    public int Amount;
    public int SellPrice;

    void Awake()
    {
        instance = this;
    }
    
    

    private void Start()
    {
        
    }

    public void Getmoney()
    {
        money += 100;
        
    }

    
}

