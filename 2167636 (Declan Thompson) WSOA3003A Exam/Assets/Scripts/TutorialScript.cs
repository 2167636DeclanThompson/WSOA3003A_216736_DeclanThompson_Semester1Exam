using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialScript : MonoBehaviour
{
    public GameObject DickAngel;
    public GameObject Angel;
    public GameObject TextBox;

    public Text TutorialText;

    public void Start()
    {
        StartCoroutine(Tutorial());
    }

    public void Update()
    {
        
    }

    IEnumerator Tutorial()
    {
        yield return new WaitForSeconds(1f);
        TextBox.SetActive(true);
        Angel.SetActive(true);
        TutorialText.text = "Mornin' Dick. I've got a new case for you.";
        yield return new WaitForSeconds(6f);
        Angel.SetActive(false);
        DickAngel.SetActive(true);
        TutorialText.text = "What is it this time? Another pointless argument about who has the shinier halo?";
        yield return new WaitForSeconds(6f);
        DickAngel.SetActive(false);
        Angel.SetActive(true);
        TutorialText.text = "Luckily for you, it's not. It's something much bigger... much more important.";
        yield return new WaitForSeconds(6f);
        Angel.SetActive(false);
        DickAngel.SetActive(true);
        TutorialText.text = "Really? You don't say... So I'm finally getting my big break since coming to Heaven, huh? I've waited more than 80 years for this... Alright, what's the job?";
        yield return new WaitForSeconds(6f);
        DickAngel.SetActive(false);
        Angel.SetActive(true);
        TutorialText.text = "We can't really talk about it out loud - it's a top secret case. Classified, you know how it is. Just read the details in this case file and when you're ready to take the job, come see me.";
        yield return new WaitForSeconds(6f);
        TutorialText.text = "And remember: this job is a secret. So keep it under wraps and don't tell anybody about it, capiche?";
        yield return new WaitForSeconds(6f);
        Angel.SetActive(false);
        DickAngel.SetActive(true);
        TutorialText.text = "Alright, let me see what this case is about...";
        yield return new WaitForSeconds(6f);
        TextBox.SetActive(false);
        DickAngel.SetActive(false);


    }
}
