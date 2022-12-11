using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minerubi : MonoBehaviour
{
    bool mining = false;
    float time = 0.0f;
    static float limittime = 7f;
    public static int danga = 4000;
    void Start() 
    {

    }
    void FixedUpdate()
    {
        if(mining==true)
        {
            time += Time.deltaTime;

            if (time >= limittime)
            {
                MoneyController.money += danga;
                Destroy(gameObject);
                
                Debug.Log("Destroyed");
            }
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "rail")
        {
            mining = true;
            Debug.Log("mining" + mining);
            
        }

    }
    
    /*public float FadeTime = 2f; // Fade효과 재생시간
    Image fadeImg;
    float start;
    float end;
    float time = 0f;
    bool isPlaying = false;
    void Awake()
    {
        fadeImg = GetComponent<Image>();
        InStartFadeAnim();
    }
    public void OutStartFadeAnim()
    {
        if (isPlaying == true) //중복재생방지
        {
            return;
        }
        start = 1f;
        end = 0f;
        StartCoroutine("fadeoutplay");    //코루틴 실행
    }
    public void InStartFadeAnim()
    {
        if (isPlaying == true) //중복재생방지
        {
            return;
        }
        StartCoroutine("fadeIntanim");
    }
    IEnumerator fadeoutplay()
    {
        isPlaying = true;
        Color fadecolor = fadeImg.color;
        time = 0f;
        color.a = Mathf.Lerp(start, end, time);
        while (fadecolor.a > 0f)
        {
            time += Time.deltaTime / FadeTime;
            fadecolor.a = Mathf.Lerp(start, end, time);
            fadeImg.color = fadecolor;
            yield return null;
        }
        isPlaying = false;

    }*/
}
