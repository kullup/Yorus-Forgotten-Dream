using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Checkpoint : MonoBehaviour
{
    public string nextLevel = "Lvl1";

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().setRespawnPos(this.transform.position);
            Debug.Log(this.transform.position);
            Destroy(gameObject);
            StartCoroutine("showSavingPointText");
        }
    }
}
