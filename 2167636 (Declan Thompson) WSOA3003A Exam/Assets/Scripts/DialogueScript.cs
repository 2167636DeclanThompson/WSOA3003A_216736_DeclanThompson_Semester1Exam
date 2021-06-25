using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueScript : MonoBehaviour
{
    public GameObject DickAngel;
    public GameObject Vampire;
    public GameObject TextBox;

    public Text DialogueText;

    public bool FinalDialogue;

    public bool TimeUp;

    public TimerScript timerScript;

    public GameObject finalDialogue;

    public void Start()
    {
        StartCoroutine(Dialogue());
        FinalDialogue = false;
        TimeUp = false;
    }

    private void Update()
    {
        if (FinalDialogue == true)
        {
            finalDialogue.SetActive(true);
        }
    }

    public void Time()
    {
        StartCoroutine(TimesUp());
    }
    
    IEnumerator Dialogue()
    {
        yield return new WaitForSeconds(1f);
        Vampire.SetActive(true);
        TextBox.SetActive(true);
        DialogueText.text = "Ah, you must be Detective Angel. I am Prince Marth. Welcome to my family's manor. Tell me, Mr. Angel: how are you enjoying your time in Hell so far?";
        yield return new WaitForSeconds(6f);
        Vampire.SetActive(false);
        DickAngel.SetActive(true);
        DialogueText.text = "Well, it's dark here, and Hell is hot. This is my first time here and I must say I'm not all that crazy about it.";
        yield return new WaitForSeconds(6f);
        Vampire.SetActive(true);
        DickAngel.SetActive(false);
        DialogueText.text = "I see... Well, that's truly a shame, but I suppose that means you will want to leave as soon as possible. I hope your investigation is quick.";
        yield return new WaitForSeconds(6f);
        Vampire.SetActive(false);
        DickAngel.SetActive(true);
        DialogueText.text = "We'll see about that. I know I haven't been granted a lot of time but trust me, if there's something to find, I'll find it.";
        yield return new WaitForSeconds(6f);
        Vampire.SetActive(true);
        DickAngel.SetActive(false);
        DialogueText.text = "If I may, Detective. I hope you don't take this personally but... if you ask me, I believe you are wasting your time. There is nothing to find here.";
        yield return new WaitForSeconds(6f);
        DialogueText.text = "Even if the girl had been here that night, this room is my personal study - she would not have set foot in this room. Even I barely use this room myself these days.";
        yield return new WaitForSeconds(6f);
        Vampire.SetActive(false);
        DickAngel.SetActive(true);
        DialogueText.text = "Is that so? Well, the case file seems to report that an eyewitness account saw Helga entering this house on the night she disappeared.";
        yield return new WaitForSeconds(6f);
        Vampire.SetActive(true);
        DickAngel.SetActive(false);
        DialogueText.text = "They lie! There was no meeting here between us Vampires and that Witch! They must have seen something else!";
        yield return new WaitForSeconds(6f);
        Vampire.SetActive(false);
        DickAngel.SetActive(true);
        DialogueText.text = "Calm down, Mr. Prince. There's no need to get so defensive over something you claim is false... Funny, I didn't mention the possibility that Helga was here for a meeting with the Vampires.";
        yield return new WaitForSeconds(6f);
        Vampire.SetActive(true);
        DickAngel.SetActive(false);
        DialogueText.text = "Well that's... I, um... Anyway, I'll leave you to your pointless investigation now! You have 5 minutes, so I suggest you use it wisely Detective.";
        yield return new WaitForSeconds(6f);
        Vampire.SetActive(false);
        DickAngel.SetActive(true);
        DialogueText.text = "I'll keep that in mind. Now let's see: where should I start?";
        yield return new WaitForSeconds(6f);
        TextBox.SetActive(false);
        DickAngel.SetActive(false);
        timerScript.inDialogue = false;

    }
        

    IEnumerator TimesUp()
    {
        timerScript.inDialogue = true;
        Vampire.SetActive(true);
        TextBox.SetActive(true);
        DialogueText.text = "Unfortunately, your time for investigation has run out, Mr. Angel. I suggest you leave... now.";
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene(5);
    }
}
