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
    public MainMenu MainMenu;
    public GameObject Player;

    public Vector3 respawnPos;

    void Start() {
        respawnPos = Player.transform.position;
    }

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
        Debug.Log("Game Paused");
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        PauseMenu.Hide();
        gameIsPaused = false;
        Debug.Log("Game Resumed");
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        gameHasEnded = false;
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Player.transform.position = respawnPos;
        GameOverScreen.Hide();
        Debug.Log("Game Restarted");
    }

    public void playerDied()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            GameOverScreen.Show();
        }
        Debug.Log("Player Died");
    }

    public void ShowMainMenu()
    {
        GameOverScreen.Hide();
        PauseMenu.Hide();
        MainMenu.Show();
    }

    public void LevelCompleted(string nextLevel)
    {
        SceneManager.LoadScene(nextLevel);
    }

    public void setRespawnPos(Vector3 pos) {
        respawnPos = pos;
    }
}
