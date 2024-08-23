using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 鼠标移动，使用鼠标模拟一个简单的摇杆


public class L4MouseMover : MonoBehaviour
{
    private Vector3 beginPos;
    void Update()
    {
        // 鼠标左键按下的时候记录开始坐标
        if (Input.GetMouseButtonDown(0))
        {
            beginPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        // 鼠标左键按住的时候，根据移动调整物体的最新位置
        if (Input.GetMouseButton(0))
        {
            var pt = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position += pt - beginPos;
            beginPos = pt;
        }
    }
}
