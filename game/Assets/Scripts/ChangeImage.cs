using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{ 
    public Image TestImage; //기존에 존제하는 이미지
    public Sprite SpriteExp1; //바뀌어질 이미지
    public Sprite SpriteExp2;
    public Sprite SpriteExp3;

    public void ChangeIm()
    {
        TestImage.sprite = SpriteExp1; //TestImage에 SourceImage를 TestSprite에 존제하는 이미지로 바꾼다.
    }
}
