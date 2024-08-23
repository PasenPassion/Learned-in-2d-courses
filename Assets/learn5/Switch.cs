using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    /// <summary>
    /// ��ť���أ�����������
    /// </summary>
    private L6Generator generator;
    private bool kaiguan;

    void Start()
    {
        // ��������������
        generator = GetComponent<L6Generator>();
        // �������ر�
        generator.enabled = false;
    }
    

    private void OnTriggerEnter2D(Collider2D other)
    {

        //�����������崥������,��һ�ο������ιر�
        kaiguan = !kaiguan;
    }
    private void Update()
    {
        
        if (kaiguan == true)
            generator.enabled = true;


    }
}

