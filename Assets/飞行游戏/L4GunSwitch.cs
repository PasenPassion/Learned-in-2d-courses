using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 火炮的开关
/// </summary>
[RequireComponent(typeof(L4Gun))]
public class L4GunSwitch : MonoBehaviour
{
    /// <summary>
    /// 火炮指向，确定是哪个火炮的属性变量
    /// </summary>
    private L4Gun gun;
    void Start()
    {
        // 获得火炮的组件，由于限定的火炮，所以在此获得
        gun = GetComponent<L4Gun>();
        // 火炮激活关闭
        gun.enabled = false;
    }

    void Update()
    {
        // 根据鼠标是否按下才激活火炮
        gun.enabled = Input.GetMouseButton(0);
    }
}
