using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L4Player : MonoBehaviour
{
    public int value =3;
    void Update()
    {



        if (value <= 0)
        {
            Destroy(gameObject);
        }
    }
}
