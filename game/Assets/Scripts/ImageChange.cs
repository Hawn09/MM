using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChange : MonoBehaviour
{
    public Sprite[] num;
    public Image image;
    public int n = 0;
    void Start()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnClick();
        }
    }
 
    public void OnClick()
    {
        image.sprite = num[n];
        n++;
        if(n == 3)
        {
            n = 0;
        }
    }


}
