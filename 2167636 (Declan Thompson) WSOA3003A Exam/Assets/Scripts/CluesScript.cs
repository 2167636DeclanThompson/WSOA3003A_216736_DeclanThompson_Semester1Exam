using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CluesScript : MonoBehaviour
{
    public Text clueText;

    public int Clues;

    public GameManager gameManager;
    public DialogueScript dialogueScript;

    public void Update()
    {
        if (Clues >= 10)
        {
            dialogueScript.FinalDialogue = true;
        }
    }

    public void PlayerScored(int playerID)
    {
        if (playerID == 1)
        {
            Clues++;

        }
        UpdateScore();
        {


        }
    }

    private void UpdateScore()
    {
        clueText.text = Clues.ToString();

    }

    
}
