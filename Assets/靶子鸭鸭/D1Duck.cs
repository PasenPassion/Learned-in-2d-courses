using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// DEMO1的鸭子移动
/// </summary>
public class D1Duck : MonoBehaviour, IPointerClickHandler
{
    /// <summary>
    /// 背面身体的物体引用
    /// </summary>
    public int Score = 1;
    public GameObject BackBody;
    public float Speed = 3;
    public ScoreManager scoreManager;
    void Start()
    {
        // 通过GameObject.FindObjectOfType方法获得
        scoreManager = GameObject.FindObjectOfType<ScoreManager>();
    }

    void Update()
    {
        Speed = Random.Range(1f, 6f);
        transform.position += Vector3.right * Time.deltaTime * Speed;
        if (transform.position.x > 12f)
        {
            ResetState();
        }
        // 如果背面可见，那么进行快速的反转
        if (BackBody.activeSelf)
        {
            transform.eulerAngles = Vector3.MoveTowards(transform.eulerAngles, Vector3.up * 180, Time.deltaTime * 1000);
        }
    }
    /// <summary>
    /// 重设状态
    /// </summary>
    void ResetState()
    {
        transform.eulerAngles = Vector3.zero;
        transform.position = new Vector3(-12, transform.position.y, 0);
        BackBody.SetActive(false);

    }
    /// <summary>
    /// 点击命中
    /// </summary>
    /// <param name="eventData"></param>
   

    public void OnPointerClick(PointerEventData eventData)
    {
        var Duck = GetComponent<D1Duck>();
        if (!BackBody.activeSelf)
        {
            BackBody.SetActive(true);
            scoreManager.AddScore(Duck.Score);

        }
    }

}
