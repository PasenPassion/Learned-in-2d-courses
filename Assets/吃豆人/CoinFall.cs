using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// Ӳ�ҵ���ű�
/// </summary>
public class CoinFall : MonoBehaviour
{
    public ScoreManager1 scoreManager;
    
    public GameObject Dou;
    private Vector3 dou;//��ȡ�Զ���λ��
    /// <summary>
    /// Ӧ�÷���
    /// </summary>
    public int Score = 1;
    /// <summary>
    /// �����ٶ�
    /// </summary>
    public float Speed = 6;
    void Start()
    {
        // ͨ��GameObject.FindObjectOfType�������
        scoreManager = GameObject.FindObjectOfType<ScoreManager1>();
    }
    void Update()
    {
        var dou = Dou.transform.position;
        dou.z = 0;
        var r = dou - transform.position;

        // λ�������������������
        transform.position += Vector3.down * Time.deltaTime * Speed;
        // �ж��Ƿ������Ļ��
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
    /// ����λ��
    /// </summary>
    public void ResetPosition()
    {
        // �������һ��x��λ��
        var x = Random.Range(-8f, 8f);
        // �����������������
        transform.position = new Vector3(x, 6, 0);
    }
}

