using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameOverScreen GameOverScreen;

    public void playerDied()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            GameOverScreen.setup();
        }
    }

    public void Restart()
    {
        gameHasEnded = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
