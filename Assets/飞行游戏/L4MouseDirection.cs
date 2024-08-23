
using UnityEngine;


// 根据鼠标的指向调整方向

public class L4MouseDirection : MonoBehaviour
{

    void Update()
    {
        if (Input.GetMouseButton(0))//按住鼠标左键
        {
            // 取得世界坐标
            var pt = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pt.z = 0;
            // 求向量
            var v = pt - transform.position;
            // 求角度
            var a = Vector3.Angle(Vector3.up, v);
            //从第一个向量到第二个向量，求出两向量夹角较小的那个，度数小于180，度数为正
            // a一定大于0，x>0时要往右转，需要反向
            if (v.x > 0)
            {
                a = -a;
            }
            // 飞机转向鼠标点下的位置方向
            transform.eulerAngles = new Vector3(0, 0, a);//a>0时往左转

        }
    }
}
