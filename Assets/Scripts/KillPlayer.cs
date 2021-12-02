using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    // public int Respawn;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // SceneManager.LoadScene(Respawn);
            FindObjectOfType<GameManager>().playerDied();
        }
    }
}
