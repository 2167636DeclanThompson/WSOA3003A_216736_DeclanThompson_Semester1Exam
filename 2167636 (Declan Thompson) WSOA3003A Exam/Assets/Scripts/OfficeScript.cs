using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OfficeScript : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject DickAngel;
    public Text Text;
    public Object thing;

    public enum Object { BOOKS, ASHTRAY, PAPERS, WHISKEY, COAT, HAT, BOARD }

    private void OnMouseDown()
    {
        if (thing == Object.ASHTRAY)
        {
            TextBox.SetActive(true);
            DickAngel.SetActive(true);
            Text.text = "Damn, out of cigarettes again... Maybe it's a sign I should finally quit smoking.";
            StartCoroutine(Timer());
        }
        else if (thing == Object.BOOKS)
        {
            TextBox.SetActive(true);
            DickAngel.SetActive(true);
            Text.text = "I swear, I've read these books so many times I could recite them word for word. I guess that's to be expected when I have so much free time on my hands - nothing exciting ever happens around here...";
            StartCoroutine(Timer());
        }
        else if (thing == Object.WHISKEY)
        {
            TextBox.SetActive(true);
            DickAngel.SetActive(true);
            Text.text = "Whiskey's almost finished... Guess I should slow down a little, but it's not like I got anything better to do than just drink.";
            StartCoroutine(Timer());
        }
        else if (thing == Object.PAPERS)
        {
            TextBox.SetActive(true);
            DickAngel.SetActive(true);
            Text.text = "Still got some paperwork to finish, but I suppose it can wait until I complete this new case.";
            StartCoroutine(Timer());
        }
        else if (thing == Object.HAT)
        {
            TextBox.SetActive(true);
            DickAngel.SetActive(true);
            Text.text = "Hat's starting to look a little worn. I should probably get a new one but... This one is special to me, so it wouldn't feel the same if I got rid of it.";
            StartCoroutine(Timer());
        }
        else if (thing == Object.COAT)
        {
            TextBox.SetActive(true);
            DickAngel.SetActive(true);
            Text.text = "It's gonna be warm in Hell so I probably won't need this. But it's part of my identity at this point, so I can't very well leave it behind.";
            StartCoroutine(Timer());
        }
        else if (thing == Object.BOARD)
        {
            TextBox.SetActive(true);
            DickAngel.SetActive(true);
            Text.text = "I haven't used this board once, and I bought it when I first got here over 80 years ago. Heaven doesn't have any big crime investigations that I can use this for.";
            StartCoroutine(Timer());
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(6f);
        TextBox.SetActive(false);
        DickAngel.SetActive(false);
    }
}
