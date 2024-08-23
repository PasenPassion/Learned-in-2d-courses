using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L3RoleMover : MonoBehaviour
{
    public float Speed = 10;
    void Update()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        transform.position += new Vector3(h, v, 0) * Speed * Time.deltaTime;
    }
}
