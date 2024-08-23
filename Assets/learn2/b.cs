using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b : MonoBehaviour
{

    public int score = 0;
    public Transform object1;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var pt = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pt.z = 0;
            var vector = pt - object1.position;
            var d = vector.magnitude;
            //Debug.Log(pt);
            //Debug.Log(vector);
            //Debug.Log(d);
            if (d <= 1)
            {
                Debug.Log("µãÖÐÁË");
                score += 1;
            }
            else
            {
                score = 0;
            }
            Debug.Log("score:"+ score);
        }
    }
}
