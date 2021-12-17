using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    public bool gameIsPaused = false;

    public GameOverScreen GameOverScreen;
    public PauseMenu PauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                ResumeGame();
            } else if (!gameHasEnded) {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        PauseMenu.Show();
        gameIsPaused = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        PauseMenu.Hide();
        gameIsPaused = false;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        gameHasEnded = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void playerDied()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            GameOverScreen.Show();
        }
    }
}
