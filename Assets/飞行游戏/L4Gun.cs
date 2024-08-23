using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 火炮的脚本
public class L4Gun : MonoBehaviour
{
    
    // 冷却时间
    public float Cooldown = 1;
    //计时属性变量
    public float Timer = 0;
    //子弹的预制体或复制目标
    public GameObject BulletPrefab;
    //射击函数
    public void Shoot()
    {
        // 实例化一个预制体或复制目标
        var clone = Instantiate(BulletPrefab);
        // 从克隆体中获得子弹的脚本
        var bullet = clone.GetComponent<L4Bullet>();
        // 根据飞机方向调整子弹发射的方向
        bullet.transform.rotation= transform.rotation;
        //子弹在转向的方向向前发射
        bullet.forward = transform.rotation * Vector3.up;
        // 子弹从飞机所在位置发射
        bullet.transform.position = transform.position;
        
    }
    void Update()
    {
        // 计算冷却时间
        Timer += Time.deltaTime;
        // 当时间大于冷却时间则执行发射函数
        if(Timer > Cooldown)
        {
            Timer = 0;
            // 执行发射函数
            Shoot();//执行一次克隆一次
        }
    }
}
