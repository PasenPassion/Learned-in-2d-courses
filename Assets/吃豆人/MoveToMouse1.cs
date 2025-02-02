using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 鼠标点击物体移动到目标的第二种方法
/// </summary>
public class MoveToMouse1 : MonoBehaviour
{

    private Vector3 dest;

    private void Start()
    {
        dest = transform.position;
    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            dest = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            dest.z = 0;
            
        }
        transform.position = Vector3.MoveTowards(transform.position, dest, Time.deltaTime * 10);
    }
}