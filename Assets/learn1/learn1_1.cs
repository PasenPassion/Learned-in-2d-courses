using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learn1_1 : MonoBehaviour
{
    void Start()
    {
        float d = f1(3.5f);
        Debug.Log(d);
        d = f1(9);
        Debug.Log(d);
        d = f2(5, 1000f / 15f);
        Debug.Log(d);
    }
    float f1(float time)
    {
        float speed = 1000f / 12f;
        float d = speed * time;
        return d;
    }
    float f2(float time, float speed)
    {
       return time * speed;
    }
}
