using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialogueAlone : MonoBehaviour
{
   
     private bool isPlayerInRange = true;
    private bool didDialogueStart;
    private int lineIndex;
    private float typingTime = 0.05f;
    public int level;

    [SerializeField] private TMP_Text dialogueText;
    [SerializeField, TextArea(4,10)] private string[] dialogueLines;


    private void StartDialogue()
    {
        didDialogueStart = true;
        lineIndex = 0;
        Time.timeScale = 0f;
        StartCoroutine(ShowLine());
    }

    private void NextDialogueLine()
    {
        lineIndex++;
        if(lineIndex < dialogueLines.Length)
        {
            StartCoroutine(ShowLine());
        }
        else
        {
            didDialogueStart = false;
            Time.timeScale = 1f;
            SceneManager.LoadScene(level);
        }
    }

    private IEnumerator ShowLine()
    {
        dialogueText.text = string.Empty;

        foreach(char ch in dialogueLines[lineIndex])
        {
            dialogueText.text += ch;
            yield return new WaitForSecondsRealtime(typingTime);
        }
    }

    void Update()
    {
        if(isPlayerInRange)
        {
            if(!didDialogueStart)
            {
                StartDialogue();
            }
            else if(dialogueText.text == dialogueLines[lineIndex] && Input.GetButtonDown("Fire1"))
            {
                NextDialogueLine();
            }
        }
    }

}
