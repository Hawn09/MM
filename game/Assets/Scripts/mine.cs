/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mine : MonoBehaviour
{
    GameObject Obj_Field;            //배경 판넬 참조할 게임 오브젝트

    Image image;                        //판네의 이미지 값을 참조할 이미지 UI



    void Start()        //게임이 실행하면

    {

        Obj_Field = GameObject.Find("gwangmul rubi");            //Field 이름을 찾아 오브젝트 참조

        image = Obj_Field.GetComponent<Image>();  //참조한 오브젝트의 이미지를 컴포넌트 

    }



    void Update()

    {

        if (Obj_Field.activeSelf)                                //게임 오브젝트가 참이면

        {

            Color color = image.color;        //오브젝트 이미지의 컬러를 새로 선언한 컬러로 참조



            //알파값을 내려주기 위해 1에서 0으로 for문 반복

            for (float i = 1.0f; i >= 0.0f; i -= 0.01f)

            {

                color.a = i;                   //i가 내려가면서 선언한 컬러의 알파 값에 참조

                image.color = color;       //i로 인해 내려간 알파 값을 다시 오브젝트 이미지에 참조

            }

        }

    }
}
*/