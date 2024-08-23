using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L6Spring : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        var contact = other.GetContact(0);
        if (contact.normal.y < 0) 
        {
          other.rigidbody.AddForce(Vector2.up * 300);//³åÁ¿
        }
    }
}
