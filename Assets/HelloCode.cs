using System;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    private void Start()
    {
        // 조건문
        int love = 80;

        if (love > 90)
        {
            Debug.Log("트루엔딩: 히로인과 결혼했다!");
        } 
        else if (love > 70)
        {
            Debug.Log("굿엔딩: 히로인과 사귀게 되었다!");
        }
        else
        {
            Debug.Log("배드엔딩: 히로인에게 차였다.");
        }

        // 논리 연산자
        int age = 11;

        if (age > 7 && age < 18)
        {
            Debug.Log("의무 교육을 받고 있습니다.");
        }

        if (age < 13 || age > 70)
        {
            Debug.Log("일을 할 수 없는 나이입니다.");
        }
        
        // for 문
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i + "번째 순번입니다.");
        }
        
        // while 문
        int j = 0;

        while (j < 10)
        {
            Debug.Log(j + "번째 루프입니다.");
            j++;
        }
    }
}
