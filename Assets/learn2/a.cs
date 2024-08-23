using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a : MonoBehaviour
{
    float time = 0;
    void Update()
    {
        time = time + Time.deltaTime;//µÈÍ¬ÓÚtime+=Time.deltaTime;
        if(time>=1)
        {
            time = 0;
            //transform.position = new Vector3(-3.75f, 2, 0);
            //transform.Translate(new Vector3(0.1f, -0.1f, 0));
            float x = Random.Range(-9f, 9f);
            float y = Random.Range(-4f, 4f);
            transform.position = new Vector3(x, y, 0);
        }
    }
}
