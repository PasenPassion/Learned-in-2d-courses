using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lizi : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //第一种移动
        //transform.position = transform.position + Vector3.right * Time.deltaTime * 10;
        //transform.position += Vector3.right * Time.deltaTime * 10;
       
        float speed = 10;
        float distance = speed * Time.deltaTime;
        float x = transform.position.x + distance;
        if(x>10)
        {
            x = 0;
        }
        transform.position = new Vector3(x, transform.position.y, 0); //第二种移动
    }
}
