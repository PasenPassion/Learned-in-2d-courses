using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// DEMO1的物体摇晃效果
/// </summary>
public class D1ObjectSway : MonoBehaviour
{
    public Vector3 Speed;
    public float TimeSpan = 3f;
    float time = 0;
    
    void Update()
    {
        time += Time.deltaTime;
        if(time > TimeSpan)
        {
            time = 0;
            Speed = -Speed;
        }
        transform.position += Time.deltaTime * Speed;
    }
}
