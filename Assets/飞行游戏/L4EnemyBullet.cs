using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L4EnemyBullet : MonoBehaviour
{
    // ǰ��������ʸ����
    public Vector3 forward = Vector3.zero;
    // �ٶ�
    public float Speed = 10;

    void Update()
    {
        // �����ٶ���ǰ�����
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
