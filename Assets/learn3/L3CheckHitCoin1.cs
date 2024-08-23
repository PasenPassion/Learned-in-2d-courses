using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 点击检查脚本
/// </summary>
public class L3CheckHitCoin1 : MonoBehaviour
{
    // 半径
    public float radius = 1;
    // 分数管理器
    public L3ScoreManager scoreManager;
    void Start()
    {
        // 通过GameObject.FindObjectOfType方法获得
        scoreManager = GameObject.FindObjectOfType<L3ScoreManager>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // 屏幕点击坐标转到世界坐标
            var pt = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pt.z = 0;
            // 计算它们之间的向量
            var v = pt - transform.position;
            // 判断距离
            if (v.magnitude <= radius)
            {
                // 获得掉落脚本，执行重设位置
                var coinFall = GetComponent<L3CoinFall>();
                coinFall.ResetPosition();
                if (scoreManager != null)
                {
                    scoreManager.AddScore(coinFall.Score);
                }
            }
        }
    }
}
