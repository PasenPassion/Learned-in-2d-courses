using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 鼠标点击移动到目标的第一种方法
/// </summary>
public class L3MoveToMousePosition1 : MonoBehaviour
{
    private Vector3 dest;
    private void Start()
    {
        dest = transform.position;
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            dest = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            dest.z = 0;
        }
        // 计算向量
        var v = dest - transform.position;
        // 判断距离
        if (v.magnitude > 0.5f)
        {
            // 按照向量位移，用标准向量乘以时间和速度得到每个循环时走的距离
            transform.position += v.normalized * Time.deltaTime * 10;
        }
    }
}
