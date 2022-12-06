using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public Text moneytext;
    public int money;
    public int Amount;
    public int SellPrice;

    void Awake()
    {
        instance = this;
    }
    
    

    private void Start()
    {
        SetText();
    }

    public void Getmoney()
    {
        money += 100;
        SetText();
    }

    public void SetText()
    {
        text.text = "µ· : " + money.ToString();
    }
}

