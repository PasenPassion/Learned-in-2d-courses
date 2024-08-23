using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L3CheckOutScreen : MonoBehaviour
{

    void Update()
    {
        // 判断是否掉出屏幕外
        if (transform.position.y <= -6)
        {
            // 随机出来一个x的位置
            var x = Random.Range(-8f, 8f);
            // 设置物体的世界坐标
            transform.position = new Vector3(x, 6, 0);
        }
    }
}
