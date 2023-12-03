using System;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    private void Start()
    {
        float distance = GetDistance(2, 2, 5, 6);
        Debug.Log("(2,2)에서 (5,6)까지의 거리 : " + distance);
    }

    private float GetDistance(int x1, int y1, int x2, int y2)
    {
        float width = x2 - x1;
        float height = y2 - y1;

        float distance = width * width + height + height;
        distance = Mathf.Sqrt(distance);

        return distance;
    }
}
