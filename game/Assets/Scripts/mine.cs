/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mine : MonoBehaviour
{
    GameObject Obj_Field;            //��� �ǳ� ������ ���� ������Ʈ

    Image image;                        //�ǳ��� �̹��� ���� ������ �̹��� UI



    void Start()        //������ �����ϸ�

    {

        Obj_Field = GameObject.Find("gwangmul rubi");            //Field �̸��� ã�� ������Ʈ ����

        image = Obj_Field.GetComponent<Image>();  //������ ������Ʈ�� �̹����� ������Ʈ 

    }



    void Update()

    {

        if (Obj_Field.activeSelf)                                //���� ������Ʈ�� ���̸�

        {

            Color color = image.color;        //������Ʈ �̹����� �÷��� ���� ������ �÷��� ����



            //���İ��� �����ֱ� ���� 1���� 0���� for�� �ݺ�

            for (float i = 1.0f; i >= 0.0f; i -= 0.01f)

            {

                color.a = i;                   //i�� �������鼭 ������ �÷��� ���� ���� ����

                image.color = color;       //i�� ���� ������ ���� ���� �ٽ� ������Ʈ �̹����� ����

            }

        }

    }
}
*/