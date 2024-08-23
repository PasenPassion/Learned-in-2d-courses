using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class XiaoMing
{
    public float speed = 10;
    public float MoveX(float time)
    {
        return speed * time;
    }
}

public class learn1_2 : MonoBehaviour 
{
    void Start()
    {
        XiaoMing xm = new XiaoMing();
            float d = xm.MoveX(6);
        Debug.Log(d);
        XiaoMing xm2 = new XiaoMing();
        xm2.speed = 12;
        d = xm2.MoveX(6);
        Debug.Log(d);
    }
    public GameObject XiaoMingBody;
    // Update is called once per frame
    void Update()
    {
        XiaoMing xm = new XiaoMing();
        float d = xm.MoveX(Time.deltaTime);
        float x = XiaoMingBody.transform.position.x;
        x = x + d;
        if(x>10)
        { 
            x = 0;
        }
        XiaoMingBody.transform.position = new Vector3(x, 0, 0);
    }
}
