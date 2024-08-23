using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L7FollowTarget : MonoBehaviour
{
	public Transform target;

    // Update is called once per frame
    void Update()
	{
		var pt=new Vector3(target.transform.position.x,target.transform.position.y,transform.position.z);
		transform.position=pt;
    }
}
