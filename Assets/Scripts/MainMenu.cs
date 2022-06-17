using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public GameObject GameManager;
	public Button Level1BtnGameObj;
	public Button Level2BtnGameObj;
	public Button Level3BtnGameObj;

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
		Button Level1Btn = Level1BtnGameObj.GetComponent<Button>();
		Button Level2Btn = Level2BtnGameObj.GetComponent<Button>();
		Button Level3Btn = Level3BtnGameObj.GetComponent<Button>();

		Level1Btn.onClick.AddListener(LevelButton1OnClick);
		Level2Btn.onClick.AddListener(LevelButton2OnClick);
		Level3Btn.onClick.AddListener(LevelButton3OnClick);
	}

	void LevelButton1OnClick()
	{
		SceneManager.LoadScene("IntroLvl1");
		gameObject.SetActive(false);
		GameManager.GetComponent<GameManager>().ResumeGame();
	}

	void LevelButton2OnClick()
	{
		SceneManager.LoadScene("IntroLvl2");
		gameObject.SetActive(false);
		GameManager.GetComponent<GameManager>().ResumeGame();
	}

	void LevelButton3OnClick()
	{
		SceneManager.LoadScene("IntroLvl3");
		gameObject.SetActive(false);
		GameManager.GetComponent<GameManager>().ResumeGame();
	}
}