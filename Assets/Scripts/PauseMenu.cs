using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
	public Button restartButtonGameObj;
	public Button menuButtonGameObj;
	public Button resumeButtonGameObj;
	public GameObject GameManager;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space))
		{
			GameManager.GetComponent<GameManager>().ResumeGame();
		}
	}

	public void Show()
	{
		gameObject.SetActive(true);
	}

	public void Hide()
	{
		gameObject.SetActive(false);
	}

	void Start()
	{
		Button restartButton = restartButtonGameObj.GetComponent<Button>();
		Button menuButton = menuButtonGameObj.GetComponent<Button>();
		Button resumeButton = resumeButtonGameObj.GetComponent<Button>();

		restartButton.onClick.AddListener(restartOnClick);
		menuButton.onClick.AddListener(MenuOnClick);
		resumeButton.onClick.AddListener(resumeOnClick);
	}

	void restartOnClick()
	{
		GameManager.GetComponent<GameManager>().RestartGame();
	}

	void resumeOnClick()
	{
		GameManager.GetComponent<GameManager>().ResumeGame();
		Debug.Log("Resume Button Pressed");
	}

	void MenuOnClick()
    {
		GameManager.GetComponent<GameManager>().ShowMainMenu();
		gameObject.SetActive(false);
    }
}
