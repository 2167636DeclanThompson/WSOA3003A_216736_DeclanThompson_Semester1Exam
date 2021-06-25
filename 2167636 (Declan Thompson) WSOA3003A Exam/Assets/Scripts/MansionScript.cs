using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MansionScript : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject DickAngel;
    public GameObject Note;
    public Text Text;
    public Object thing;
    public GameManager gameManager;
    public NoteScript noteScript;

    public GameObject Fire;
    public GameObject Cupboards;
    public GameObject Drawer;
    public GameObject Book;
    

    public enum Object { ENVELOPE, BOOK, PAINTING, DRAWER, FIRE, WINE, GLASSES, WINDOW, SHELF, CUPBOARD, COUCH, CHAIR }
    
    private void OnMouseDown()
    {
        if (thing == Object.ENVELOPE)
        {
            if (gameManager.Envelope == false)
            {
                TextBox.SetActive(true);
                DickAngel.SetActive(true);
                Text.text = "An opened envelope, but no letter in sight... Perhaps I'll find it somewhere else.";
                gameManager.Envelope = true;
                StartCoroutine(Clue());
            }
            else if (gameManager.Envelope == true)
            {
                TextBox.SetActive(true);
                DickAngel.SetActive(true);
                Text.text = "An opened envelope, but no letter in sight... Perhaps I'll find it somewhere else.";
                StartCoroutine(Timer());
            }
           
        }
        else if (thing == Object.BOOK)
        {
            if (gameManager.Painting == true && gameManager.Key == false)
            {
                TextBox.SetActive(true);
                DickAngel.SetActive(true);
                Text.text = "Hmmm... The painting shows three fingers on the right hand. So if I try the third book from the right...";
                StartCoroutine(BookShelf());
            }
            else if (gameManager.Painting == false)
            {
                TextBox.SetActive(true);
                DickAngel.SetActive(true);
                Text.text = "There's a lot of books here. I've never heard of some of these before... must be exclusive to Hell.";
                StartCoroutine(Timer());
            }
            if (gameManager.Key == true)
            {
                TextBox.SetActive(true);
                DickAngel.SetActive(true);
                Text.text = "Smart place to hide a key, but unfortunately not smart enough... Made a mistake by letting the painting give it away. Are these vampires that forgetful that they need a visual reminder?";
                StartCoroutine(Timer());
            }
        }
        else if (thing == Object.PAINTING)
        {
            if (gameManager.Painting == false)
            {
                TextBox.SetActive(true);
                DickAngel.SetActive(true);
                Text.text = "Looks like a portrait of the Vampire Family's patriarch. I heard he actually passed away not too long ago... Strange, I wonder why he's holding up three fingers on his right hand?";
                gameManager.Painting = true;                
                StartCoroutine(Clue());
            }
            else if (gameManager.Painting == true)
            {
                TextBox.SetActive(true);
                DickAngel.SetActive(true);
                Text.text = "Looks like a portrait of the Vampire Family's patriarch. I heard he actually passed away not too long ago... Strange, I wonder why he's holding up three fingers on his right hand?";
                StartCoroutine(Timer());
            }
            
        }
        else if (thing == Object.DRAWER)
        {
            if (gameManager.Key2 == false && noteScript.Note == false)
            {
                TextBox.SetActive(true);
                DickAngel.SetActive(true);
                Text.text = "Drawer is locked, which means they might be hiding something in it. If only I had the key for it...";
                StartCoroutine(Timer());
            }
            else if (gameManager.Key2 == true && gameManager.Key == true && noteScript.Note == false)
            {
                TextBox.SetActive(true);
                DickAngel.SetActive(true);
                Text.text = "The key I found in the fireplace fits this lock! Now, let's what they're hiding in here...";
                StartCoroutine(Drawers());
            }
            if (gameManager.Key == true && noteScript.Note == false && gameManager.Key2 == false)
            {
                TextBox.SetActive(true);
                DickAngel.SetActive(true);
                Text.text = "Damn, this doesn't look like the right key for this drawer. Maybe there's another one around here somewhere?";
                StartCoroutine(Timer());
            }
            if (noteScript.Note == true)
            {
                TextBox.SetActive(true);
                DickAngel.SetActive(true);
                Text.text = "This letter is the strongest piece of evidence against the Vampires, no wonder they tried to hide it.";
                StartCoroutine(Timer());
            }
            
        }
        else if (thing == Object.FIRE)
        {
            if (gameManager.Water == false && gameManager.Key2 == false)
            {
                TextBox.SetActive(true);
                DickAngel.SetActive(true);
                Text.text = "Wait, what's that? There seems to be something in the fireplace, but I can't get to it while the fire is burning.";
                StartCoroutine(Timer());
            }
            else if (gameManager.Water == true && gameManager.Key2 == false)
            {
                TextBox.SetActive(true);
                DickAngel.SetActive(true);
                Text.text = "Alright, if I put out the fire with the water I found, I can get to whatever is in there.";
                StartCoroutine(Fireplace());
            }
            if (gameManager.Key2 == true)
            {
                TextBox.SetActive(true);
                DickAngel.SetActive(true);
                Text.text = "Seems like the key was thrown in there quickly to hide it from something... Whoever threw it in there clearly isn't the smartest.";
                StartCoroutine(Timer());
            }
        }
        else if (thing == Object.WINE)
        {
            if (gameManager.Wine == false)
            {
                TextBox.SetActive(true);
                DickAngel.SetActive(true);
                Text.text = "Wine was only opened recently by the smell, and it's almost finished as well. This stuff seems quite strong... I can't imagine one person drinking all of this by themselves.";
                gameManager.Wine = true;
                StartCoroutine(Clue());
            }
            else if (gameManager.Wine == true)
            {
                TextBox.SetActive(true);
                DickAngel.SetActive(true);
                Text.text = "Wine was only opened recently by the smell, and it's almost finished as well. This stuff seems quite strong... I can't imagine one person drinking all of this by themselves.";
                StartCoroutine(Timer());
            }
            
        }
        else if (thing == Object.GLASSES)
        {
            if (gameManager.Glasses == false)
            {
                TextBox.SetActive(true);
                DickAngel.SetActive(true);
                Text.text = "These glasses are still dirty. Looks like they were put away in a hurry... Now why would both of them be dirty? Seems like there was more than one person in here at the same time, and the two probably had a drink together while they talked.";
                gameManager.Glasses = true;
                StartCoroutine(Clue());
            }
            else if (gameManager.Glasses == true)
            {
                TextBox.SetActive(true);
                DickAngel.SetActive(true);
                Text.text = "These glasses are still dirty. Looks like they were put away in a hurry... Now why would both of them be dirty? Seems like there was more than one person in here at the same time, and the two probably had a drink together while they talked.";
                StartCoroutine(Timer());
            }
            
        }
        else if (thing == Object.WINDOW)
        {
            TextBox.SetActive(true);
            DickAngel.SetActive(true);
            Text.text = "Quite the view... It's just burnt trees and red skies as far as the eye can see. Why is everything always on fire down here, anyway?";
            StartCoroutine(Timer());
        }
        else if (thing == Object.SHELF)
        {
            TextBox.SetActive(true);
            DickAngel.SetActive(true);
            Text.text = "There's a lot of books here. I've never heard of some of these before... must be exclusive to Hell.";
            StartCoroutine(Timer());
        }
        else if (thing == Object.CUPBOARD)
        {
            if (gameManager.Key == false)
            {
                TextBox.SetActive(true);
                DickAngel.SetActive(true);
                Text.text = "Hmmm... This cupboard seems to be locked. I wonder if there's a key for it around somewhere?";
                StartCoroutine(Timer());
            }
            else if (gameManager.Key == true && gameManager.Water == false)
            {
                TextBox.SetActive(true);
                DickAngel.SetActive(true);
                Text.text = "I can unlock this cupboard with the key I found in that book. Let's see what's inside...";
                StartCoroutine(Cupboard());
            }
            if (gameManager.Water == true && gameManager.Key2 == false)
            {
                TextBox.SetActive(true);
                DickAngel.SetActive(true);
                Text.text = "Doesn't look like there's anything else in here...";
                StartCoroutine(Timer());
            }
            if (gameManager.Key2 == true)
            {
                TextBox.SetActive(true);
                DickAngel.SetActive(true);
                Text.text = "Doesn't look like there's anything else in here...";
                StartCoroutine(Timer());
            }
        }
        else if (thing == Object.CHAIR)
        {
            if (gameManager.Chair == false)
            {
                TextBox.SetActive(true);
                DickAngel.SetActive(true);
                Text.text = "There's still a slight imprint in this chair, which means someone must have sat in it fairly recently. But for what purpose I wonder?";
                gameManager.Chair = true;                
                StartCoroutine(Clue());
            }
            else if (gameManager.Chair == true)
            {
                TextBox.SetActive(true);
                DickAngel.SetActive(true);
                Text.text = "There's still a slight imprint in this chair, which means someone must have sat in it fairly recently. But for what purpose I wonder?";
                StartCoroutine(Timer());
            }
            
        }
        else if (thing == Object.COUCH)
        {
            if (gameManager.Couch == false)
            {
                TextBox.SetActive(true);
                DickAngel.SetActive(true);
                Text.text = "Interesting, there appear to be wine stains on this couch... Clearly someone was drinking wine in here recently, but who? And why?";
                gameManager.Couch = true;                
                StartCoroutine(Clue());
            }
            else if (gameManager.Couch == true)
            {
                TextBox.SetActive(true);
                DickAngel.SetActive(true);
                Text.text = "Interesting, there appear to be wine stains on this couch... Clearly someone was drinking wine in here recently, but who? And why?";
                StartCoroutine(Timer());
            }
            
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(6f);
        TextBox.SetActive(false);
        DickAngel.SetActive(false);
    }

    IEnumerator Clue()
    {
        yield return new WaitForSeconds(6f);
        gameManager.PlayerScored(1);
        TextBox.SetActive(false);
        DickAngel.SetActive(false);
    }

    IEnumerator BookShelf()
    {
        
        yield return new WaitForSeconds(6f);
        Book.SetActive(true);
        Text.text = "Aha! There's a key hidden here in this book! I wonder what it unlocks?";
        yield return new WaitForSeconds(6f);
        Book.SetActive(false);
        gameManager.Key = true;
        gameManager.PlayerScored(1);
        TextBox.SetActive(false);
        DickAngel.SetActive(false);
    }

    IEnumerator Cupboard()
    {
        
        yield return new WaitForSeconds(6f);
        Cupboards.SetActive(true);
        Text.text = "There's some water in here. I could probably use this to put out the fire.";
        yield return new WaitForSeconds(6f);
        Cupboards.SetActive(false);
        gameManager.Water = true;        
        TextBox.SetActive(false);
        DickAngel.SetActive(false);
    }

    IEnumerator Fireplace()
    {
       
        gameManager.Water = false;        
        yield return new WaitForSeconds(6f);
        Fire.SetActive(true);
        Text.text = "Aha! It's another key! This must be the one that unlocks that drawer in the desk!";
        yield return new WaitForSeconds(6f);
        Fire.SetActive(false);
        gameManager.Key2 = true;
        gameManager.PlayerScored(1);
        TextBox.SetActive(false);
        DickAngel.SetActive(false);
    }

    IEnumerator Drawers()
    {
        
        yield return new WaitForSeconds(6f);
        Drawer.SetActive(true);
        Text.text = "There's a letter in here! Probably the one that belonged in that open envelope on the coffee table. Let's see what it says...";
        gameManager.PlayerScored(1);
        yield return new WaitForSeconds(6f);
        Drawer.SetActive(false);
        TextBox.SetActive(false);
        DickAngel.SetActive(false);
        Note.SetActive(true);
        
    }
}
