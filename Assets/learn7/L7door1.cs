using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L7door : MonoBehaviour
{
	public GameObject panel;
	// Sent when another object leaves a trigger collider attached to this object (2D physics only).
	protected void OnTriggerExit2D(Collider2D other)
	{
		panel.SetActive(false);
	}
}
