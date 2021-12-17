using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
	public Button restartButton;
	public GameObject GameManager;

    public void Show()
    {
        gameObject.SetActive(true);
    }

	void Start()
	{
		Button btn = restartButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		GameManager.GetComponent<GameManager>().RestartGame();
	}
}