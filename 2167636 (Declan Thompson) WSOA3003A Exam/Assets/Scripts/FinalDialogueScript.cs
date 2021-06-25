using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinalDialogueScript : MonoBehaviour
{
    public TimerScript timerScript;
    public GameObject Vampire;
    public GameObject DickAngel;
    public Text DialogueText;
    public GameObject TextBox;
        

    private void Start()
    {
        StartCoroutine(Finale());
    }

    IEnumerator Finale()
    {
        timerScript.inDialogue = true;
        yield return new WaitForSeconds(1f);
        Vampire.SetActive(true);
        TextBox.SetActive(true);
        DialogueText.text = "Well, Detective Angel? How goes your little investigation?";
        yield return new WaitForSeconds(6f);
        Vampire.SetActive(false);
        DickAngel.SetActive(true);
        DialogueText.text = "Pretty good so far, if I do say so myself. I've found quite a bit of information which may prove useful in fnding the culprit.";
        yield return new WaitForSeconds(6f);
        Vampire.SetActive(true);
        DickAngel.SetActive(false);
        DialogueText.text = "Is that a fact? So, you're convinced that the witch girl was here before she went missing. I bet you also think we had something to do with it...";
        yield return new WaitForSeconds(6f);
        Vampire.SetActive(false);
        DickAngel.SetActive(true);
        DialogueText.text = "Let's not get ahead of ourselves here, Prince Marth. I'm not blaming anyone... yet. All I'm saying is I have evidence which could point to who did it, that's all.";
        yield return new WaitForSeconds(6f);
        Vampire.SetActive(true);
        DickAngel.SetActive(false);
        DialogueText.text = "Oh really? I suppose you wouldn't mind sharing some of this so called 'evidence' with me, then?";
        yield return new WaitForSeconds(6f);
        Vampire.SetActive(false);
        DickAngel.SetActive(true);
        DialogueText.text = "It's supposed to be confidential, but... I suppose I'll make an exception for you. Okay, to start off, I noticed some wine stains on the couch over there.";
        yield return new WaitForSeconds(6f);
        Vampire.SetActive(true);
        DickAngel.SetActive(false);
        DialogueText.text = "I spilt some of my wine last time I was in here. What of it?";
        yield return new WaitForSeconds(6f);
        Vampire.SetActive(false);
        DickAngel.SetActive(true);
        DialogueText.text = "The stains seemed quite recent, and I seem to recall you saying you haven't used this room in a while. Somehow, those two facts don't seem to add up.";
        yield return new WaitForSeconds(6f);
        DialogueText.text = "Additionally, I could tell that the wine bottle had only been opened recently based on the smell. Trust me, an alcoholic's nose never fails him when it comes to things like that...";
        yield return new WaitForSeconds(6f);
        DialogueText.text = "Also, given how strong the wine seems to be, I couldn't possibly imagine one person drinking through all of it by themselves in one night. Two people on the other hand... Well, both glasses were dirty so it is a possibility...";
        yield return new WaitForSeconds(6f);
        DialogueText.text = "All of that, coupled with the recent looking groove in that chair, leads me to suspect that there may have been some sort of rendezvous in here within the last few days, maybe to discuss important matters over a glass of wine.";
        yield return new WaitForSeconds(6f);
        Vampire.SetActive(true);
        DickAngel.SetActive(false);
        DialogueText.text = "That's quite a preposterous claim, Detective. And frankly, your supposed 'evidence' is not nearly strong enough to suggest something like that.";
        yield return new WaitForSeconds(6f);
        Vampire.SetActive(false);
        DickAngel.SetActive(true);
        DialogueText.text = "I'm not finished. I also happened to notice this here envelope on the coffee table - opened, with the letter nowhere to be found.";
        yield return new WaitForSeconds(6f);
        Vampire.SetActive(true);
        DickAngel.SetActive(false);
        DialogueText.text = "That letter was nothing important! I already burned it in the fire long before the little witch girl disappeared.";
        yield return new WaitForSeconds(6f);
        Vampire.SetActive(false);
        DickAngel.SetActive(true);
        DialogueText.text = "Really? You don't say... I suppose you threw it in the fire around the same time you threw this key in there, as well?";
        yield return new WaitForSeconds(6f);
        Vampire.SetActive(true);
        DickAngel.SetActive(false);
        DialogueText.text = "That's... Well... I don't know what you're talking about! I've never seen that key in my life!";
        yield return new WaitForSeconds(6f);
        Vampire.SetActive(false);
        DickAngel.SetActive(true);
        DialogueText.text = "Hm, interesting. Well, as it happens, this key unlocked that drawer which just so happened to contain a letter in it... A letter almost like the one you claim to have burned.";
        yield return new WaitForSeconds(6f);
        DialogueText.text = "A letter written by the Witch Apprentice Helga, in which she agrees to a secret meeting with one Vampire Prince Marth in order to discuss a possible alliance between the two clans.";
        yield return new WaitForSeconds(6f);
        DialogueText.text = "A meeting which supposedly took place in this very room on the night of her disappearance. Care to explain, Your Highness?";
        yield return new WaitForSeconds(6f);
        Vampire.SetActive(true);
        DickAngel.SetActive(false);
        DialogueText.text = "You lie! That letter was probably forged in order to implicate me! How dare you accuse me of such a thing! I am innocent!";
        yield return new WaitForSeconds(6f);
        Vampire.SetActive(false);
        DickAngel.SetActive(true);
        DialogueText.text = "Uh huh. We'll just have to see about that, but for the time being, I'm gonna have to bring you in for questioning. Come on, let's go!";
        yield return new WaitForSeconds(6f);
        TextBox.SetActive(false);
        DickAngel.SetActive(false);
        SceneManager.LoadScene(4);
    }
}
