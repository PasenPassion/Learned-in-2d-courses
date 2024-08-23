using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
/// <summary>
/// 点击检查脚本
/// </summary>
public class L3CheckHitCoin2 : MonoBehaviour,IPointerEnterHandler
{
    // 分数管理器
    public L3ScoreManager scoreManager;
    void Start()
    {
        // 通过GameObject.FindObjectOfType方法获得
        scoreManager = GameObject.FindObjectOfType<L3ScoreManager>();
    }
 

    public void OnPointerEnter(PointerEventData eventData)
    {
        var coinFall = GetComponent<L3CoinFall>();
        coinFall.ResetPosition();
        if (scoreManager != null)
        {
            scoreManager.AddScore(coinFall.Score);
        }
    }
}
