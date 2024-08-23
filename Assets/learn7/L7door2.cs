using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L7door2 : MonoBehaviour
{
	public string sceneName;
	// Sent when another object enters a trigger collider attacheo
	protected void OnTriggerEnter2D(Collider2D other)
	{
		SceneManager.LoadScene(sceneName);
	}
}
