using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L6GravitySwitch : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Physics2D.gravity = -Physics2D.gravity;
    }
    void Update()
    {
        
    }
}
