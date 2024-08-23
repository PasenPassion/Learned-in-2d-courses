using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text TextScore;
    /// <summary>
    /// 分数记录
    /// </summary>
    int score = 0;
    /// <summary>
    /// 增加分数函数
    /// </summary>
    /// <param name="num">具体分数</param>
    public void AddScore(int num)
    {
        score += num;
        UpdateText();
    }
    /// <summary>
    /// 设置分数函数
    /// </summary>
    /// <param name="num">具体分数</param>
    public void SetScore(int num)
    {
        score = num;
        UpdateText();
    }
    /// <summary>
    /// 刷新文本UI
    /// </summary>
    private void UpdateText()
    {
        string outputStr = "当前分数：" + score;
        Debug.Log(outputStr);
        if (TextScore != null)
        {
            TextScore.text = outputStr;
        }
    }
}
