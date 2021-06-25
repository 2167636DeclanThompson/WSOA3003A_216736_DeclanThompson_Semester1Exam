using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public GameObject Key1;
    public GameObject Water;
    public GameObject Key2;
    public GameObject Letter;

    public GameObject EnvelopeClue;
    public GameObject ChairClue;
    public GameObject CouchClue;
    public GameObject PaintingClue;
    public GameObject BookClue;
    public GameObject FireClue;
    public GameObject WineClue;
    public GameObject GlassesClue;
    public GameObject LetterClue;
    public GameObject DrawersClue;

    public GameManager gameManager;
       

    private void Update()
    {
        if (gameManager.Key == true)
        {
            Key1.SetActive(true);
            BookClue.SetActive(true);
            
        }

        if (gameManager.Key2 == true)
        {
            Key2.SetActive(true);
            FireClue.SetActive(true);
            
        }

        if (gameManager.Water == true)
        {
            Water.SetActive(true);            
        }

        if (gameManager.Letter == true)
        {
            Letter.SetActive(true);
            DrawersClue.SetActive(true);
            LetterClue.SetActive(true);
            
        }

        if (gameManager.Painting == true)
        {
            PaintingClue.SetActive(true);            

        }

        if (gameManager.Envelope == true)
        {
            EnvelopeClue.SetActive(true);
            
        }

        if (gameManager.Wine == true)
        {
            WineClue.SetActive(true);
           
        }

        if (gameManager.Glasses == true)
        {
            GlassesClue.SetActive(true);
            
        }

        if (gameManager.Chair == true)
        {
            ChairClue.SetActive(true);
            
        }

        if (gameManager.Couch == true)
        {
            CouchClue.SetActive(true);
            
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
       

    public void ChapterOne()
    {
        SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
