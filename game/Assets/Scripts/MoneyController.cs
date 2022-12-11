using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoneyController : MonoBehaviour
{
    public TextMeshProUGUI TextTMP;
    
    public static int money = 3000;

    private void Start()
    {
        SetText();
    }
    private void Update()
    {
        SetText();
    }

    public void GetScore()
    {
        money += 100;
        SetText();
    }

    public void SetText()
    {
        TextTMP.text = "µ· º¸À¯·® : " + money.ToString() + " ¿ø ";
    }

}