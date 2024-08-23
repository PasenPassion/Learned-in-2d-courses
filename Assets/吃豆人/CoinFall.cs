using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// 硬币掉落脚本
/// </summary>
public class CoinFall : MonoBehaviour
{
    public ScoreManager1 scoreManager;
    
    public GameObject Dou;
    private Vector3 dou;//获取吃豆人位置
    /// <summary>
    /// 应得分数
    /// </summary>
    public int Score = 1;
    /// <summary>
    /// 掉落速度
    /// </summary>
    public float Speed = 6;
    void Start()
    {
        // 通过GameObject.FindObjectOfType方法获得
        scoreManager = GameObject.FindObjectOfType<ScoreManager1>();
    }
    void Update()
    {
        var dou = Dou.transform.position;
        dou.z = 0;
        var r = dou - transform.position;

        // 位移整个物体的世界坐标
        transform.position += Vector3.down * Time.deltaTime * Speed;
        // 判断是否掉出屏幕外
        if (transform.position.y <= -6 || r.magnitude < 1)
        {
            ResetPosition();
        }
        var coinFall = GetComponent<CoinFall>();
        if (scoreManager != null&& r.magnitude < 1)
        {

            scoreManager.AddScore(coinFall.Score);
        }

    }
    /// <summary>
    /// 重设位置
    /// </summary>
    public void ResetPosition()
    {
        // 随机出来一个x的位置
        var x = Random.Range(-8f, 8f);
        // 设置物体的世界坐标
        transform.position = new Vector3(x, 6, 0);
    }
}

