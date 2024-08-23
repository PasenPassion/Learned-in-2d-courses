
using UnityEngine;

// 子弹脚本
public class L4Bullet : MonoBehaviour
{
    // 前向向量（矢量）
    public Vector3 forward = Vector3.zero;
    // 速度
    public float Speed = 10;

    void Update()
    {
        // 按照速度向前向飞行
        transform.position += forward * Speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        //Destroy(other.gameObject);
        var ship = other.GetComponent<L4Ship>();
        if(ship!=null)
        {
            ship.Value -= 1;
        }
    }
}