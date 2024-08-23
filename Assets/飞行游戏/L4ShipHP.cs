
using UnityEngine;

/// <summary>
/// 飞船的HP脚本
/// </summary>
public class L4ShipHP : MonoBehaviour
{
    /// <summary>
    /// 血量数值
    /// </summary>
    public int Value = 1;
    /// <summary>
    /// 是否自动销毁
    /// </summary>
    public bool AutoDestroy = true;
    /// <summary>
    /// 变化数字
    /// </summary>
    /// <param name="num"></param>
    public void AddHP(int num)
    {
        Value += num;
        if(Value <= 0 && AutoDestroy)
        {
            Destroy(gameObject);
        }
    }
}
