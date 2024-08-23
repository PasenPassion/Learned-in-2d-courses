
using UnityEngine;


// 敌人AI1
//它只会向下行进，当超出一定范围就销毁自己所在的游戏物体
public class L4EnemyAI1 : MonoBehaviour
{
    public float Speed = 3;
    
    void Update()
    {
        // 向下移动
        transform.position += Vector3.down * Speed * Time.deltaTime;
        // y 小于 -6的位置时，销毁游戏物体
        if(transform.position.y <= -6)
        {
            Destroy(gameObject);
        }
    }
}
