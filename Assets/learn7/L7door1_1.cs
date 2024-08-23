using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L7door1_1 : MonoBehaviour
{
	public GameObject panel;
	// Sent when another object enters a trigger collider attached to this object (2D physics only).
	protected void OnTriggerEnter2D(Collider2D other)
	{
		panel.SetActive(true);
	}
	// Sent when another object leaves a trigger collider attached to this object (2D physics only).
	public void GotoNextLevel()
	{
		SceneManager.LoadScene("learn7_1");//要切换到的场景
	}
}
