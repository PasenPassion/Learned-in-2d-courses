using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L7Role1 : MonoBehaviour
{
	void start()
	{
		DontDestroyOnLoad(gameObject);
	}
	public Joystick joystick;
	public float speed=5f;
	
    void Update()
	{
		float h=joystick.Horizontal;
		float v=joystick.Vertical;
		var vector=new Vector3(h,v,0)*speed*Time.deltaTime;
		transform.position+=vector;
		if(h!=0)
			transform.localScale=new Vector3(h>0?1:-1,1);
		
    }
}
