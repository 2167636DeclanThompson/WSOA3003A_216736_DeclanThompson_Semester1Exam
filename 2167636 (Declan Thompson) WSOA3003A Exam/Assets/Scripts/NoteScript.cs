using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScript : MonoBehaviour
{
    public bool Note;
    public DialogueScript dialogueScript;
    public GameManager gameManager;

    private void Start()
    {
        Note = false;
    }

    private void Update()
    {
        if (Note == true)
        {
            gameManager.Letter = true;
        }
    }

    public void Continue()
    {
        gameManager.PlayerScored(1);
        Note = true;
    }
}
