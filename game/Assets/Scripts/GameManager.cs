using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public int money;
    public int Amount;
    public int SellPrice;

    void Awake()
    {
        instance = this;
    }

}

