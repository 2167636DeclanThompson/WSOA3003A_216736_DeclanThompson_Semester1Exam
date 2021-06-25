using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaseFileScript : MonoBehaviour
{
    public GameObject CaseFile;
    public bool File;

    private void Start()
    {
        File = false;
    }

    private void OnMouseDown()
    {
        CaseFile.SetActive(true);
        File = true;
    }
}
