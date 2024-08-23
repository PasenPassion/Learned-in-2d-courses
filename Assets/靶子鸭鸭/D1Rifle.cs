using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 步枪脚本
/// </summary>
public class D1Rifle : MonoBehaviour
{
    
    /// <summary>
    /// 瞄准星的引用
    /// </summary>
    public Transform CrossHair;
    /// <summary>
    /// 原始的Y坐标
    /// </summary>
    float oy;
    void Start()
    {
        oy = transform.position.y;
    }
    void Update()
    {
        // 取得屏幕鼠标上的对应世界坐标
        var pt = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pt.z = 0;
        // 调整瞄准星的位置
        CrossHair.transform.position = pt;
        // 修正枪的位置
        transform.position = new Vector3(pt.x+2, pt.y / 10 + oy , 0);
    }
}
