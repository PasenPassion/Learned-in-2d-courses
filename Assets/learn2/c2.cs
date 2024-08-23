using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c2 : MonoBehaviour
{
    public L2ScoreManager scoreManager;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var pt = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pt.z = 0;
            var vector = pt - transform.position;
            var d = vector.magnitude;

            if (d <= 1.5)
            {
                scoreManager.score -= 1;
                
                if (scoreManager.score <= 0)
                {
                    scoreManager.score = 0;
                    
                }
                
                    Debug.Log("Score:" + scoreManager.score);
                


            }


        }
    }
}
