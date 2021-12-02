using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int Respawn;

    public void playerDied()
    {
        SceneManager.LoadScene(Respawn);
    }
}
