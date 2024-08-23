using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text TextScore;
    /// <summary>
    /// ������¼
    /// </summary>
    int score = 0;
    /// <summary>
    /// ���ӷ�������
    /// </summary>
    /// <param name="num">�������</param>
    public void AddScore(int num)
    {
        score += num;
        UpdateText();
    }
    /// <summary>
    /// ���÷�������
    /// </summary>
    /// <param name="num">�������</param>
    public void SetScore(int num)
    {
        score = num;
        UpdateText();
    }
    /// <summary>
    /// ˢ���ı�UI
    /// </summary>
    private void UpdateText()
    {
        string outputStr = "��ǰ������" + score;
        Debug.Log(outputStr);
        if (TextScore != null)
        {
            TextScore.text = outputStr;
        }
    }
}
