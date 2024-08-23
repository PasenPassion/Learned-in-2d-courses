
using UnityEngine;
/// <summary>
/// 碰撞处理脚本
/// </summary>
public class L4TriggerEnterHandle : MonoBehaviour
{
    /// <summary>
    /// 伤害值
    /// </summary>
    public int Damage = 1;
    /// <summary>
    /// 碰撞触发函数
    /// 该函数的触发条件是目标物体必须有 2D刚体和2D碰撞体
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        var shipHp = collision.GetComponent<L4ShipHP>();
        if(shipHp != null)
        {
            shipHp.AddHP(-Damage);
        }
    }
}
