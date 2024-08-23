using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L4EnemyBullet : MonoBehaviour
{
    // 前向向量（矢量）
    public Vector3 forward = Vector3.zero;
    // 速度
    public float Speed = 10;

    void Update()
    {
        // 按照速度向前向飞行
        transform.position += forward * Speed * Time.deltaTime;
        
        var player = GameObject.FindObjectOfType<L4Player>();
        if (player != null)
        {
            var distance = player.transform.position - transform.position;
            distance.z = 0;
            var r = distance.magnitude;
            if (r <= 0.1)
            {
                player.value -= 1;
                Destroy(gameObject);
            }
        }
    }
  
}
