using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L4EnemyGun : MonoBehaviour
{
    // ��ȴʱ��
    public float Cooldown = 1;
    //��ʱ���Ա���
    public float Timer = 0;
    //�ӵ���Ԥ�������Ŀ��
    public GameObject BulletPrefab;
    //�������
    public void Shoot()
    {
        // ʵ����һ��Ԥ�������Ŀ��
        var clone = Instantiate(BulletPrefab);
        // �ӿ�¡���л���ӵ��Ľű�
        var bullet = clone.GetComponent<L4EnemyBullet>();
        // ���ݵл���������ӵ�����ķ���
        bullet.transform.rotation = transform.rotation;
        //�ӵ���ת��ķ�����ǰ����
        bullet.forward = transform.rotation * Vector3.down;
        // �ӵ��ӵл�����λ�÷���
        bullet.transform.position = transform.position;

    }
    void Update()
    {
        // ������ȴʱ��
        Timer += Time.deltaTime;
        // ��ʱ�������ȴʱ����ִ�з��亯��
        if (Timer > Cooldown)
        {
            Timer = 0;
            // ִ�з��亯��
            Shoot();//ִ��һ�ο�¡һ��
        }
    }
}
