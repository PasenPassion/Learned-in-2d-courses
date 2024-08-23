using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager1 : MonoBehaviour
{
    public Text TextScore;
    int score = 1;
    public void AddScore(int num)
    {
        score += num;
        UpdateText();
    }
    
    public void SetScore(int num)
    {
        score = num;
        UpdateText();
    }
    
    private void UpdateText()
    {
        string outputStr = "当前分数：" + score;
        Debug.Log(outputStr);
        if (TextScore != null)
        {
            TextScore.text = outputStr;
        }
    }

    private void Start()
    {
        
    }
}
