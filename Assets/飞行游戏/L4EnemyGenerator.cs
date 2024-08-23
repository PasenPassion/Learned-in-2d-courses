
using UnityEngine;

//敌人生成脚本
public class L4EnemyGenerator : MonoBehaviour
{
    //预制体或者复制的目标
    public GameObject Prefab;
    //冷却时间，这个时间控制产生间隔
    public float Cooldown = 1;
    //时间记录
    public float Timer = 0;
    // 创建一个敌人的函数
    void CreateOne()
    {
        var pt = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(0, 1f), 1.2f));
        pt.z = 0;
        var clone = Instantiate(Prefab);
        clone.transform.position = pt;
    }
    void Update()
    {
        // 冷却时间再不停的增加
        Timer += Time.deltaTime;
        // 超过冷却时间最大数值，就触发创建
        if (Timer > Cooldown)
        {
            Timer = 0;
            CreateOne();
        }

    }
}
