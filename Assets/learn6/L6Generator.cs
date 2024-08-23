using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L6Generator : MonoBehaviour
{
    public Vector2 vector;
    public Rigidbody2D Prefab;
    public float Timespan=0.5f;
    public float timer=0;
    
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>Timespan)
        {
            timer = 0;
            var clone = Instantiate(Prefab);
            clone.transform.position = transform.position;
            clone.AddForce(vector);
        }
    }
}
