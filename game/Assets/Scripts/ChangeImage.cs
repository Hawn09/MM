using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{ 
    public Image TestImage; //������ �����ϴ� �̹���
    public Sprite SpriteExp1; //�ٲ���� �̹���
    public Sprite SpriteExp2;
    public Sprite SpriteExp3;

    public void ChangeIm()
    {
        TestImage.sprite = SpriteExp1; //TestImage�� SourceImage�� TestSprite�� �����ϴ� �̹����� �ٲ۴�.
    }
}
