using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chidouren : MonoBehaviour
{
    public ScoreManager1 scoreManager;
    public int Score = 1;
    private Vector3 dou;//��ȡ�Զ���λ��

   
        
        private void OnTriggerEnter2D(Collider2D other)
        {
        Destroy(other.gameObject);
        var chidouren = GetComponent<chidouren>();
        if (scoreManager != null)
            {
	        
                scoreManager.AddScore(chidouren.Score);
            }
        }
    
}
