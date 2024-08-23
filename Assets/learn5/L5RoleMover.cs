using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L5RoleMover : MonoBehaviour
{

    public float Speed = 5;
    public float Jumppower = 3;
    public Transform CheckGroundPoint;
    public LayerMask CheckLayerMask;
    void Update()
    {
        var h = Input.GetAxis("Horizontal");
        float v = GetComponent<Rigidbody2D>().velocity.y;
        h *= Speed;
        GetComponent<Animator>().SetBool("Walk", h != 0);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            v += Jumppower;
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(h, v);
        if(h!=0)
        {
            float scaleX = 1;
            if(h<0)
            {
                scaleX = -1;
            }
            transform.localScale = new Vector3(scaleX, 1, 1);
        }
        //transform.position += new Vector3(h, v, 0) * Speed * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        var collider = Physics2D.OverlapCircle(CheckGroundPoint.position, 0.1f,CheckLayerMask);
        GetComponent<Animator>().SetBool("Jump", collider == null);
    }
}
