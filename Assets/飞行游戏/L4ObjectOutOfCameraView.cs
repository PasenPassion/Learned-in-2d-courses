
using UnityEngine;

/// <summary>
/// 超出屏幕销毁的脚本
/// </summary>
public class L4ObjectOutOfCameraView : MonoBehaviour
{
    void Update()
    {
        // 从物体的世界坐标取得屏幕范围点
        Vector3 viewportPoint = Camera.main.WorldToViewportPoint(transform.position);
        // 超出了标准范围则处理下面的逻辑
        if( viewportPoint.x < 0f || viewportPoint.x > 1f || viewportPoint.y < 0f || viewportPoint.y > 1f)
        {
            Destroy(gameObject);
        }
    }
}
