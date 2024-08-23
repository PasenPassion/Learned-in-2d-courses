using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    /// <summary>
    /// 按钮开关，控制生成器
    /// </summary>
    private L6Generator generator;
    private bool kaiguan;

    void Start()
    {
        // 获得生成器的组件
        generator = GetComponent<L6Generator>();
        // 生成器关闭
        generator.enabled = false;
    }
    

    private void OnTriggerEnter2D(Collider2D other)
    {

        //碰到其他物体触发开关,碰一次开碰两次关闭
        kaiguan = !kaiguan;
    }
    private void Update()
    {
        
        if (kaiguan == true)
            generator.enabled = true;


    }
}

