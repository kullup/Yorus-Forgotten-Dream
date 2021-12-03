using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
	public Button yourButton;
	public GameObject GameManager;

    public void setup()
    {
        gameObject.SetActive(true);
    }

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		GameManager.GetComponent<GameManager>().Restart();
	}
}