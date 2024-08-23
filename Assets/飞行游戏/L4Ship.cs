
using UnityEngine;

//敌机的HP脚本

public class L4Ship : MonoBehaviour
{
    // 血量数值

    public int Value = 1;

    public void Update()
    {

        if (Value <= 0)
        {
            Destroy(gameObject);
        }


    }
    
}
    
