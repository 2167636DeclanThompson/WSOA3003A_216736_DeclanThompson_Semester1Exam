using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public Text TimerText;
    public float Timer = 300f;
    public bool inDialogue;
    public DialogueScript dialogueScript;

    private void Start()
    {
        inDialogue = true;
    }

    private void Update()
    {
        if (inDialogue == false)
        {
            Timer -= Time.deltaTime;
            TimerText.text = (Timer).ToString("0");
            if (Timer < 0)
            {
                dialogueScript.Time();
            }
        }
        else if (inDialogue == true)
        {
            TimerText.text = Timer.ToString("0");
        }
        
    }
}
