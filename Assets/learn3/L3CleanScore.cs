using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
/// <summary>
/// 清理分数
/// </summary>
public class L3CleanScore : MonoBehaviour, IPointerClickHandler
{
    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(123123);
        FindObjectOfType<L3ScoreManager>().SetScore(0);
    }
}
