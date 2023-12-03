using System;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    private void Start()
    {
        int[] students = new int[5];

        students[0] = 100;
        students[1] = 90;
        students[2] = 80;
        students[3] = 70;
        students[4] = 60;

        for (int i = 0; i < students.Length; i++)
        {
            Debug.Log(i + "번 학생의 점수: " + students[i]);
        }
    }
}
