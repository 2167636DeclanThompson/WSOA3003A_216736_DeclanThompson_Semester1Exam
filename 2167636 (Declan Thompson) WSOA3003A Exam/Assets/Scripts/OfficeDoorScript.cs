using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OfficeDoorScript : MonoBehaviour
{
    public CaseFileScript FileScript;

    public GameObject TextBox;
    public GameObject DickAngel;
    public Text Text;

    private void OnMouseDown()
    {
        if (FileScript.File == false)
        {
            TextBox.SetActive(true);
            DickAngel.SetActive(true);
            Text.text = "I really wish I could just go home but I should probably see what this new job is about.";
            StartCoroutine(Stay());
        }
        else if (FileScript.File == true)
        {
            TextBox.SetActive(true);
            DickAngel.SetActive(true);
            Text.text = "Alright, I should probably get going. The trip to Hell is gonna be a long one...";
            StartCoroutine(NextLevel());
        }

    }

    IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene(2);
    }

    IEnumerator Stay()
    {
        yield return new WaitForSeconds(6f);
        TextBox.SetActive(false);
        DickAngel.SetActive(false);
    }

}
