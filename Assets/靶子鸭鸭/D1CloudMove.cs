using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// DEMO1的云彩的移动
/// </summary>
public class D1CloudMove : MonoBehaviour
{
    public float Speed = 3;
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * Speed;
        if (transform.position.x < -12f)
        {
            // 移动到屏幕外面就返回
            transform.position = new Vector3(12, transform.position.y, 0);
        }
    }
}
